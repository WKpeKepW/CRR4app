namespace CRR4app
{
    public partial class Form1 : Form
    {
        string path;
        ExcelWorker ew;
        bool ewWorked = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\Download";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    path = openFileDialog.FileName;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (path == null)
                MessageBox.Show("Сначала выберите файл");
            else if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Выберите промежуток корректирования");
            else if (int.Parse(textBox1.Text) > int.Parse(textBox2.Text))
                MessageBox.Show("Начальное значение не может быть больше конечного значение");
            else
            {
                if (ewWorked)
                {
                    ewWorked = false;
                    ew.Dispose();
                }
                ew = new ExcelWorker(path, 1);
                SetManyProcent(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text),
                         int.Parse(textBox5.Text), int.Parse(textBox6.Text), int.Parse(textBox7.Text), int.Parse(textBox8.Text),
                         int.Parse(textBox9.Text), int.Parse(textBox10.Text), int.Parse(textBox11.Text), int.Parse(textBox12.Text),
                         int.Parse(textBox13.Text), int.Parse(textBox14.Text), int.Parse(textBox15.Text));
                ew.SaveAs("Откорректированный файл.xlsx");
                ewWorked = true;
            }
        }

        private void SetManyProcent(int Start, int Finish, int OldProcentColumCommission, int NewProcentColumCommission, int PriceSalesman, int PriceImplement, int AmountGoods, int NewTotalSum, int Oldcomission, int NewModifiedComission, int surchargeOZON, int returnSign, int returnOzon, int returnCommision, int returnTotal)
        {
            for (int i = Start; i <= Finish; i++)// смотрим только те строки которые находяться в промежутке
            {
                if (ew.ReadCellDouble(i, OldProcentColumCommission) == 0.15d && ew.ReadCell(i, PriceSalesman) != "") //если в строке старой комисии 15% и при этом остальные строки прописаны начинаем менять 
                {
                    ew.WriteToCell(i, NewProcentColumCommission, Valuedouble: 0.08d); //изменяем цену комисии
                    if (ew.ReadCellDouble(i, PriceSalesman) == ew.ReadCellDouble(i, PriceImplement)) // если цена продавца та же что и реализации
                    {
                        double priceS = ew.ReadCellDouble(i, PriceSalesman);
                        double amount = ew.ReadCellDouble(i, AmountGoods);
                        double commission = priceS * 0.08d * amount;
                        double total = priceS * amount - commission;
                        ew.WriteToCell(i, NewTotalSum, Valuedouble: total); //цена итого
                        ew.WriteToCell(i, NewModifiedComission, Valuedouble: commission);//новая комиссия
                        if (ew.ReadCell(i, returnSign) != "") //проверяем на возврат
                        { ew.WriteToCell(i, returnCommision, Valuedouble: commission); ew.WriteToCell(i, returnTotal, Valuedouble: total); }
                    }
                    else if (ew.ReadCellDouble(i, PriceSalesman) > ew.ReadCellDouble(i, PriceImplement)) // если цена продавца больше цены реализации
                    {
                        double priceS = ew.ReadCellDouble(i, PriceSalesman);
                        double priceP = ew.ReadCellDouble(i, PriceImplement);
                        double amount = ew.ReadCellDouble(i, AmountGoods);
                        double difference = priceS - priceP;
                        double commission = priceS * 0.08d;
                        double total = priceS * amount - commission * amount;
                        ew.WriteToCell(i, NewTotalSum, Valuedouble: total); //цена итого
                        if (commission > difference) // если комиссия покрывает разницу
                        {
                            if (commission - difference <= 0.12d)// доплата нужна если размер комиссии не позволяет сделать иначе
                            {
                                double surOzon = ((commission - difference) + 0.12d) * amount;
                                double newcomiss = 0.12d * amount;
                                ew.WriteToCell(i, surchargeOZON, Valuedouble: surOzon);
                                ew.WriteToCell(i, NewModifiedComission, Valuedouble: newcomiss);//новая комиссия
                                if (ew.ReadCell(i, returnSign) != "") //проверяем на возврат
                                {
                                    if (ew.ReadCellDouble(i, Oldcomission) != newcomiss)
                                        ew.WriteToCell(i, returnCommision, Valuedouble: newcomiss);
                                    ew.WriteToCell(i, returnOzon, Valuedouble: surOzon);
                                    ew.WriteToCell(i, returnTotal, Valuedouble: total);
                                }//новая комиссия
                            }
                            else //если комиссия покрывает разницу
                            {
                                double newcomiss = (commission - difference) * amount;
                                ew.WriteToCell(i, NewModifiedComission, Valuedouble: newcomiss);
                                if (ew.ReadCell(i, returnSign) != "") //проверяем на возврат
                                {
                                    if (ew.ReadCellDouble(i, Oldcomission) != newcomiss)
                                        ew.WriteToCell(i, returnCommision, Valuedouble: newcomiss);
                                    ew.WriteToCell(i, returnTotal, Valuedouble: total);
                                }//новая комиссия
                            }
                        }
                        else // если комиссия не покрывает разницу
                        {
                            double surOzon = ((difference - commission) + 0.12d) * amount;
                            double newcomiss = 0.12d * amount;
                            ew.WriteToCell(i, surchargeOZON, Valuedouble: surOzon);// цена доплаты
                            MessageBox.Show(ew.ReadCellDouble(i, Oldcomission).ToString());
                            if (ew.ReadCellDouble(i, Oldcomission) != newcomiss)//заполняем только если комиссия изменилась
                                ew.WriteToCell(i, NewModifiedComission, Valuedouble: newcomiss); //новая комиссия
                            if (ew.ReadCell(i, returnSign) != "") //проверяем на возврат
                            {
                                if (ew.ReadCellDouble(i, Oldcomission) != newcomiss)
                                    ew.WriteToCell(i, returnCommision, Valuedouble: newcomiss);
                                ew.WriteToCell(i, returnOzon, Valuedouble: surOzon);
                                ew.WriteToCell(i, returnTotal, Valuedouble: total);
                            }
                        }
                    }
                    else // если цена продавца меньше цены реализации
                    {
                        double priceS = ew.ReadCellDouble(i, PriceSalesman);
                        double priceP = ew.ReadCellDouble(i, PriceImplement);
                        double amount = ew.ReadCellDouble(i, AmountGoods);
                        double difference = (priceP - priceS) * amount;
                        double commission = priceS * 0.08d * amount;
                        double newcomiss = difference + commission;
                        double total = priceS * amount - commission;
                        ew.WriteToCell(i, NewTotalSum, Valuedouble: total);
                        ew.WriteToCell(i, NewModifiedComission, Valuedouble: newcomiss);
                        if (ew.ReadCell(i, returnSign) != "") //проверяем на возврат
                        { ew.WriteToCell(i, returnCommision, Valuedouble: commission); ew.WriteToCell(i, returnTotal, Valuedouble: total); }
                    }
                }
            }
        }

        private void PassNumber(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar) | e.KeyChar == '\b') return;
            else
                e.Handled = true;
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ewWorked)
            {
                ew.Dispose();
            }
        }
    }
}