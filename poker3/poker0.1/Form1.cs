namespace poker0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int last = 51;
        int[] PC = new int[5];
        int[] DC = new int[5];
        int fr;
        private Random rand = new Random();
        #region stats
        double PWins;
        double PLoses;
        double PWallet = 50;
        double DWins;
        double DLoses;
        double DWallet = 50;
        double jack = 150;
        #endregion
        int[] DCK = new int[52] { 21, 22, 23, 24, 31, 32, 33, 34, 41, 42, 43, 44, 51, 52, 53, 54, 61, 62, 63, 64, 71, 72, 73, 74, 81, 82, 83, 84, 91, 92, 93, 94, 101, 102, 103, 104, 111, 112, 113, 114, 121, 122, 123, 124, 131, 132, 133, 134, 141, 142, 143, 144 };

        private int Dealer(int p)
        {
            #region if
            if ((p == 0))
            {
                last = 51;
                return 0;
            }
            #endregion
            #region else
            else
            {
                int z;
                int SW;
                fr = rand.Next();
                if ((last == 0))
                {
                    return 0;
                }

                z = rand.Next(0, last);
                SW = DCK[z];
                DCK[z] = DCK[last];
                DCK[last] = SW;
                last = (last - 1);
                return DCK[last + 1];
            }
            #endregion

        }
        public void dealerLogic(ref int[] dc, double ldh)
        {
            int[] temp = new int[4];
            if (true)
            {
                if (ldh < 1)
                {
                    #region allcart
                    temp[((dc[0] % 10) - 1)] = temp[((dc[0] % 10) - 1)] + 1;
                    temp[((dc[1] % 10) - 1)] = temp[((dc[1] % 10) - 1)] + 1;
                    temp[((dc[2] % 10) - 1)] = temp[((dc[2] % 10) - 1)] + 1;
                    temp[((dc[3] % 10) - 1)] = temp[((dc[3] % 10) - 1)] + 1;
                    temp[((dc[4] % 10) - 1)] = temp[((dc[4] % 10) - 1)] + 1;
                    #endregion

                    #region for
                    for (int i = 0; i <= 3; i++)
                    {
                        if ((temp[i] >= 3))
                        {
                            for (int j = 0; j <= 4; j++)
                            {
                                if (((PC[j] % 10) != 1))
                                {
                                    PC[j] = 0;
                                }
                            }
                        }
                    }
                    #endregion

                    #region if
                    if (dc[0] / 10 == ((dc[3] / 10) + 4))
                    {
                        dc[4] = 0;
                    }
                    if (dc[1] / 10 == ((dc[4] / 10) + 4))
                    {
                        dc[4] = 0;
                    }

                    if (dc[2] == 51 | dc[2] == 52 | dc[2] == 53 | dc[2] == 54)
                    {
                        if (dc[0] == 141 | dc[0] == 142 | dc[0] == 143 | dc[0] == 144)
                        {
                            dc[1] = 0;
                        }
                    }

                    if ((dc[0] != 0 & dc[1] != 0 & dc[2] != 0 & dc[3] != 0 & dc[4] != 0))
                    {
                        dc[2] = 0;
                        dc[3] = 0;
                        dc[4] = 0;
                    }
                    #endregion
                }

                #region if
                if (ldh < 2 & ldh > 1)
                {
                    for (int i = 0; i <= 4; i++)
                    {
                        if (dc[1] / 10 != Math.Truncate((ldh * 100) - 100))
                        {
                            dc[i] = 0;
                        }
                    }

                } // END ldh < 2 & ldh > 1

                if (ldh < 3 & ldh > 2)
                    for (int i = 0; i <= 4; i++)
                    {
                        if (dc[i] / 1 == ((ldh * 1000000) - (Math.Truncate((ldh * 10000)) * 100)))
                        {
                            dc[i] = 0;
                        }
                    } // END ldh < 3 & ldh > 1
                #endregion

            }
            if (ldh < 4 & ldh > 3)
            {
                for (int i = 0; i <= 4; i++)
                {
                    if (dc[1] / 10 != Math.Truncate((ldh * 100) - 300))
                    {
                        dc[i] = 0;
                    }
                }
            }

        }

        public void DBets()
        {
            if ((DWallet > 1500))
            {
                DWallet -= 650;
                jack += 650;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if ((DWallet > 1200))
            {
                DWallet -= 700;
                jack += 650;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if ((DWallet > 1000))
            {
                DWallet -= 500;
                jack += 500;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if (((DWallet > 1000)))
            {
                DWallet -= 400;
                jack += 400;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if ((DWallet > 750))
            {
                DWallet -= 550;
                jack += 550;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if (((DWallet > 650)))
            {
                DWallet -= 400;
                jack += 400;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if ((DWallet > 650))
            {
                DWallet -= 150;
                jack += 150;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if (((DWins > PWins) && ((DWallet > 500))))
            {
                DWallet -= 500;
                jack += 500;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if ((DWallet > 450))
            {
                DWallet -= 300;
                jack += 300;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if (((DWallet > 450)))
            {
                DWallet -= 375;
                jack += 375;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if ((DWallet > 300))
            {
                DWallet -= 150;
                jack += 150;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if ((DWallet > 200))
            {
                DWallet -= 50;
                jack += 50;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if ((DWallet > 100))
            {
                DWallet -= 75;
                jack += 75;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }
            else if ((DWallet > 75))
            {
                DWallet -= 15;
                jack += 15;
                label18.Text = DWallet.ToString("C2");
                label11.Text = jack.ToString("C2");
            }

        }

        private void sort(ref int[] hand)
        {
            int c;
            for (int z = 0; z <= 3; z++)
            {
                for (int x = z + 1; x <= 4; x++)
                {
                    if ((hand[x] > hand[z]))
                    {
                        c = hand[z];
                        hand[z] = hand[x];
                        hand[x] = c;
                    }
                }
            }
        }
        private void play_Click(object sender, EventArgs e)
        {
            int i;
            this.Dealer(0);
            for (i = 0; (i <= 4); i++)
            {
                PC[i] = this.Dealer(1);
                DC[i] = this.Dealer(1);
            }
            label12.Text = "Карты выданы";
            this.sort(ref PC);
            this.sort(ref DC);
            #region picture
            pictureBox6.ImageLocation = Application.StartupPath + "\\cards\\" + PC[0].ToString() + ".png";
            pictureBox7.ImageLocation = Application.StartupPath + "\\cards\\" + PC[1].ToString() + ".png";
            pictureBox8.ImageLocation = Application.StartupPath + "\\cards\\" + PC[2].ToString() + ".png";
            pictureBox9.ImageLocation = Application.StartupPath + "\\cards\\" + PC[3].ToString() + ".png";
            pictureBox10.ImageLocation = Application.StartupPath + "\\cards\\" + PC[4].ToString() + ".png";
            pictureBox5.ImageLocation = Application.StartupPath + "\\cards\\" + "bf.png";
            pictureBox4.ImageLocation = Application.StartupPath + "\\cards\\" + "bf.png";
            pictureBox3.ImageLocation = Application.StartupPath + "\\cards\\" + "bf.png";
            pictureBox2.ImageLocation = Application.StartupPath + "\\cards\\" + "bf.png";
            pictureBox1.ImageLocation = Application.StartupPath + "\\cards\\" + "bf.png";
            #endregion
            checkBox1.Show();
            checkBox2.Show();
            checkBox3.Show();
            checkBox4.Show();
            #region vision
            mesh.Enabled = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;

            mn1.Enabled = true;
            mn2.Enabled = true;
            mn3.Enabled = true;
            mn4.Enabled = true;
            mn5.Enabled = true;
            mn6.Enabled = true;
            #endregion
            #region info
            label15.Text = (PWins.ToString() + "/10");
            label14.Text = PLoses.ToString();
            label13.Text = PWallet.ToString("C2");
            label16.Text = (DWins.ToString() + "/10");
            label17.Text = DLoses.ToString();
            label18.Text = DWallet.ToString("C2");
            #endregion
        }
        private double highcart(ref int[] Hand)
        {
            #region int and hand
            int с1;
            int с2;
            int с3;
            int с4;
            int с5;
            с1 = Hand[0];
            с2 = Hand[1];
            с3 = Hand[2];
            с4 = Hand[3];
            с5 = Hand[4];
            #endregion
            #region ravnall
            с1 = с1 / 10;
            с2 = с2 / 10;
            с3 = с3 / 10;
            с4 = с4 / 10;
            с5 = с5 / 10;
            #endregion
            #region stats1
            double dblWeighedHand = ((с1 * 0.01) + ((с2 * 0.0001) + ((с3 * 1E-06) + ((с4 * 1E-08) + (с5 * 1E-10)))));
            return dblWeighedHand;
            #endregion
        }
        private double onePair(ref int[] hands)
        {
            double scor;
            int[] hand = new int[5];
            for (int i = 0; (i <= 4); i++)
            {
                hand[i] = (hands[i] / 10);
            }
            #region if
            if ((hand[0] == hand[1]))
            {
                scor = (1 + ((hand[0] * 0.01) + ((hand[2] * 0.0001) + ((hand[3] * 1E-06) + (hand[4] * 1E-08)))));
                return scor;
            }
            else if ((hand[1] == hand[2]))
            {
                scor = (1 + ((hand[1] * 0.01) + ((hand[0] * 0.0001) + ((hand[3] * 1E-06) + (hand[4] * 1E-08)))));
                return scor;
            }
            else if ((hand[2] == hand[3]))
            {
                scor = (1 + ((hand[2] * 0.01) + ((hand[0] * 0.0001) + ((hand[1] * 1E-06) + (hand[4] * 1E-08)))));
                return scor;
            }
            else if ((hand[3] == hand[4]))
            {
                scor = (1 + ((hand[3] * 0.01) + ((hand[0] * 0.0001) + ((hand[1] * 1E-06) + (hand[2] * 1E-08)))));
                return scor;
            }
            else
            {
                scor = 0;
                return scor;
            }
            #endregion

        }
        private double twoPair(ref int[] Cart)
        {
            double val = 0;
            #region if


            if (Cart[0] / 10 == Cart[1] / 10 & Cart[2] / 10 == Cart[3] / 10)
            {
                val = 2 + (Cart[0] / 10) * 0.01 + (Cart[2] / 10) * 0.0001 + (Cart[4] / 10) * 1E-06;
                return val;
            }
            else if (Cart[0] / 10 == Cart[1] / 10 & Cart[3] / 10 == Cart[4] / 10)
            {
                val = 2 + (Cart[1] / 10) * 0.01 + (Cart[3] / 10) * 0.0001 + (Cart[3] / 10) * 1E-06;
                return val;
            }
            else if (Cart[1] / 10 == Cart[2] / 10 & Cart[3] / 10 == Cart[4] / 10)
            {
                val = 2 + (Cart[2] / 10) * 0.01 + (Cart[3] / 10) * 0.0001 + (Cart[0] / 10) * 1E-06;
                return val;
            }
            else
            {
                return val;
            }
            #endregion
        }
        private double threeofkind(ref int[] Cart)
        {
            double value = 0;
            #region if
            if (Cart[0] / 10 == Cart[2] / 10)
            {
                value = 3 + (Cart[0] / 10) * 0.01;
                return value;
            }
            else if (Cart[1] / 10 == Cart[3] / 10)
            {
                value = 3 + (Cart[1] / 10) * 0.01;
                return value;
            }
            else if (Cart[2] / 10 == Cart[4] / 10)
            {
                value = 3 + (Cart[2] / 10) * 0.01;
                return value;
            }
            else
            {
                return value;

            }
            #endregion

        }
        private double straight(ref int[] F)
        {
            double VALUE = 0;
            #region if
            if (((F[0] / 10) - (F[1] / 10) == 1) && ((F[1] / 10) - (F[2] / 10) == 1) && ((F[2] / 10) - (F[3] / 10) == 1) && ((F[3] / 10) - (F[4] / 10) == 1))
            {
                VALUE = 4.0 + (F[0] / 10) * 0.01;
            }

            return VALUE;
            #endregion
        }
        private double flash(ref int[] C)
        {
            double VALUE = 0;
            #region if


            if ((C[0] % 10 == C[1] % 10) && (C[1] % 10 == C[2] % 10) && (C[2] % 10 == C[3] % 10) && (C[3] % 10 == C[4] % 10))
            {
                VALUE = 5.0 + ((C[0] / 10) * 0.01) + ((C[1] / 10) * 0.0001) + ((C[2] / 10) * 1E-06) + ((C[3] / 10) * 1E-08) + ((C[4] / 10) * 1E-10);
            }

            return VALUE;
            #endregion
        }
        private double fullHouse(ref int[] Cart)
        {
            double VALUE;
            VALUE = 0;

            #region IF

            if (Cart[0] / 10 == Cart[2] / 10 & Cart[3] / 10 == Cart[4] / 10)
            {
                VALUE = 6 + (Cart[0] / 10) * 0.01 + (Cart[3] / 10) * 0.0001;
                return VALUE;
            }
            else if (Cart[0] / 10 == Cart[1] / 10 & Cart[2] / 10 == Cart[4] / 10)
            {
                VALUE = 6 + (Cart[0] / 10) * 0.01 + (Cart[2] / 10) * 0.0001;
                return VALUE;
            }
            else
            {
                return VALUE;
            }
            #endregion
        }
        private double fourofkind(ref int[] Cart)
        {
            double VALUE;
            VALUE = 0;
            #region IF

            if (Cart[0] / 10 == Cart[3] / 10)
            {
                VALUE = 7 + (Cart[0] / 10) * 0.01;
                return VALUE;
            }
            else if (Cart[1] / 10 == Cart[4] / 10)
            {
                VALUE = 7 + (Cart[1] / 10) * 0.01;
                return VALUE;
            }
            else
            {
                return VALUE;
            }
            #endregion
        }
        private double straightFlush(ref int[] g)
        {
            double VALUE = 0;
            int cnt = 0;

            #region if

            if (((g[0] / 10) - (g[1] / 10) == 1) && ((g[1] / 10) - (g[2] / 10) == 1) && ((g[2] / 10) - (g[3] / 10) == 1) && ((g[3] / 10) - (g[4] / 10) == 1))
            {
                cnt = 1;
            }
            if ((g[0] % 10 == g[1] % 10) && (g[1] % 10 == g[2] % 10) && (g[2] % 10 == g[3] % 10) && (g[3] % 10 == g[4] % 10))
            {
                cnt += 1;
            }

            if ((cnt == 2))
            {
                VALUE = 8.0 + (g[0] / 10) * 0.01;
            }
            return VALUE;
            #endregion
        }
        public double ocenhand(ref int[] hand)
        {
            double res;
            res = this.straightFlush(ref hand);
            if ((res == 0))
            {
                res = this.fourofkind(ref hand);
                if ((res == 0))
                {
                    res = this.fullHouse(ref hand);
                    if ((res == 0))
                    {
                        res = this.flash(ref hand);
                        if ((res == 0))
                        {
                            res = this.straight(ref hand);
                            if ((res == 0))
                            {
                                res = this.threeofkind(ref hand);
                                if ((res == 0))
                                {
                                    res = this.twoPair(ref hand);
                                    if ((res == 0))
                                    {
                                        res = this.onePair(ref hand);
                                        if ((res == 0))
                                        {
                                            res = this.highcart(ref hand);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return res;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region enbl
            mesh.Enabled = false;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
            mn1.Enabled = false;
            mn2.Enabled = false;
            mn3.Enabled = false;
            mn4.Enabled = false;
            mn5.Enabled = false;
            mn6.Enabled = false;


            #endregion

            #region text
            label12.Text = "Игра не начата";
            label19.Text = "Цена комбинаций:\n0.0 - Старшая\n1.0 - Пара\n2.0 - Две пары\n3.0 - Сет\n4.0 - Стрит\n5.0 - Флэш\n6.0 - Фулхаус\n7.0 - Каре\n8.0 - Стрит флэш";
            label11.Text = jack.ToString("C2");
            label15.Text = (PWins.ToString() + "/10");
            label14.Text = PLoses.ToString();
            label13.Text = PWallet.ToString("C2");
            label16.Text = (DWins.ToString() + "/10");
            label17.Text = DLoses.ToString();
            label18.Text = DWallet.ToString("C2");

            #endregion

        }

        private void mesh_Click(object sender, EventArgs e)
        {
            #region stat
            double Plhand = 0;
            double Dehand = 0;
            int ttl = 0;
            #endregion

            #region checkbox check

            if ((checkBox1.Checked == true))
            {
                ttl = 1;
            }

            if ((checkBox2.Checked == true))
            {
                ttl++;
            }

            if ((checkBox3.Checked == true))
            {
                ttl++;
            }

            if ((checkBox4.Checked == true))
            {
                ttl++;
            }

            if ((checkBox5.Checked == true))
            {
                ttl++;
            }
            #endregion

            if ((ttl > 3))
            {
                MessageBox.Show("заменить можно только 3 карты", "замена(", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            #region check
            else
            {
                if ((checkBox1.Checked == true))
                {
                    PC[0] = this.Dealer(1);
                }

                if ((checkBox2.Checked == true))
                {
                    PC[1] = this.Dealer(1);
                }

                if ((checkBox3.Checked == true))
                {
                    PC[2] = this.Dealer(1);
                }

                if ((checkBox4.Checked == true))
                {
                    PC[3] = this.Dealer(1);
                }

                if ((checkBox5.Checked == true))
                {
                    PC[4] = this.Dealer(1);
                }
                mesh.Enabled = false;
                mn1.Enabled = false;
                mn2.Enabled = false;
                mn3.Enabled = false;
                mn4.Enabled = false;
                mn5.Enabled = false;
                mn6.Enabled = false;
                checkBox1.Enabled = false;
                checkBox2.Enabled = false;
                checkBox3.Enabled = false;
                checkBox4.Enabled = false;
                checkBox5.Enabled = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;
                checkBox4.Checked = false;
                checkBox5.Checked = false;
                this.sort(ref PC);
                pictureBox6.ImageLocation = (Application.StartupPath + ("\\cards\\" + (PC[0].ToString() + ".png")));
                pictureBox7.ImageLocation = (Application.StartupPath + ("\\cards\\" + (PC[1].ToString() + ".png")));
                pictureBox8.ImageLocation = (Application.StartupPath + ("\\cards\\" + (PC[2].ToString() + ".png")));
                pictureBox9.ImageLocation = (Application.StartupPath + ("\\cards\\" + (PC[3].ToString() + ".png")));
                pictureBox10.ImageLocation = (Application.StartupPath + ("\\cards\\" + (PC[4].ToString() + ".png")));
                Plhand = this.ocenhand(ref PC);
                this.dealerLogic(ref DC, Dehand);
                for (int i = 0; (i <= 4); i++)
                {
                    if ((DC[i] == 0))
                    {
                        DC[i] = this.Dealer(1);
                    }

                }
                Dehand = this.ocenhand(ref DC);
                pictureBox1.ImageLocation = (Application.StartupPath + ("\\cards\\" + (DC[0].ToString() + ".png")));
                pictureBox2.ImageLocation = (Application.StartupPath + ("\\cards\\" + (DC[1].ToString() + ".png")));
                pictureBox3.ImageLocation = (Application.StartupPath + ("\\cards\\" + (DC[2].ToString() + ".png")));
                pictureBox4.ImageLocation = (Application.StartupPath + ("\\cards\\" + (DC[3].ToString() + ".png")));
                pictureBox5.ImageLocation = (Application.StartupPath + ("\\cards\\" + (DC[4].ToString() + ".png")));
            }
            #endregion
            this.DBets();

            #region p>d
            if ((Plhand > Dehand))
            {

                label12.Text = ("Победа!" + "\n" + "Дилер: " + Dehand.ToString() + "\n" + "Игрок: " + Plhand.ToString());
                PWins = (PWins + 1);
                DLoses = (DLoses + 1);
                PWallet = (PWallet + jack);

                jack = 350;

                label11.Text = jack.ToString("C2");
                label15.Text = (PWins.ToString() + "/10");
                label14.Text = PLoses.ToString();
                label13.Text = PWallet.ToString("C2");
                label16.Text = (DWins.ToString() + "/10");
                label17.Text = DLoses.ToString();
                label18.Text = DWallet.ToString("C2");

                if ((PWins == 10))
                {
                    DialogResult result = MessageBox.Show("Ты победил!", "Всёприехали", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            #endregion

            #region draw
            else if ((Plhand == Dehand))
            {
                label12.Text = ("Ничья" + "\n" + "Дилер: " + Dehand.ToString() + "\n" + "Игрок: " + Plhand.ToString() + "\n");
            }
            #endregion

            #region d<p
            else
            {
                label12.Text = ("Вы проиграли" + "\n" + "Дилер: " + Dehand.ToString() + "\n" + "Игрок: " + Plhand.ToString() + "\n");
                DWins = (DWins + 1);
                PLoses = (PLoses + 1);
                DWallet = (DWallet + jack);
                jack = 350;
                label11.Text = jack.ToString("C2");
                label15.Text = (PWins.ToString() + "/10");
                label14.Text = PLoses.ToString();
                label13.Text = PWallet.ToString("C2");
                label16.Text = (DWins.ToString() + "/10");
                label17.Text = DLoses.ToString();
                label18.Text = DWallet.ToString("C2");

                if ((DWins == 10))
                {
                    DialogResult result = MessageBox.Show("Вы проиграли", "Всёприехали", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                    if (result == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                    else
                    {
                        this.Close(); // close the form
                    }
                }
            }
            #endregion

            #region st
            label15.Text = (PWins.ToString() + "/10");
            label14.Text = PLoses.ToString();
            label13.Text = PWallet.ToString("C2");
            label16.Text = (DWins.ToString() + "/10");
            label17.Text = DLoses.ToString();
            label18.Text = DWallet.ToString("C2");
            #endregion

        }

        private void mn1_Click(object sender, EventArgs e)
        {
            if (PWallet >= 50)
            {
                PWallet -= 50;
                jack += 50;
                label11.Text = ("₽" + jack.ToString("N2"));
                label13.Text = PWallet.ToString("C2");
            }
            else
            {
                MessageBox.Show("Нет денег", "Пустойкошелёк", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void mn2_Click(object sender, EventArgs e)
        {
            if (PWallet >= 100)
            {
                PWallet -= 100;
                jack += 100;
                label11.Text = ("₽" + jack.ToString("N2"));
                label13.Text = PWallet.ToString("C2");
            }
            else
            {
                MessageBox.Show("Нет денег", "Пустойкошелёк", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mn3_Click(object sender, EventArgs e)
        {
            if (PWallet >= 200)
            {
                PWallet -= 200;
                jack += 200;
                label11.Text = ("₽" + jack.ToString("N2"));
                label13.Text = PWallet.ToString("C2");
            }
            else
            {
                MessageBox.Show("Нет денег", "Пустойкошелёк", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mn4_Click(object sender, EventArgs e)
        {
            if (PWallet >= 300)
            {
                PWallet -= 300;
                jack += 300;
                label11.Text = ("₽" + jack.ToString("N2"));
                label13.Text = PWallet.ToString("C2");
            }
            else
            {
                MessageBox.Show("Нет денег", "Пустойкошелёк", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mn5_Click(object sender, EventArgs e)
        {
            if (PWallet >= 500)
            {
                PWallet -= 500;
                jack += 500;
                label11.Text = ("₽" + jack.ToString("N2"));
                label13.Text = PWallet.ToString("C2");
            }
            else
            {
                MessageBox.Show("Нет денег", "Пустойкошелёк", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void mn6_Click(object sender, EventArgs e)
        {
            if (PWallet >= 1000)
            {
                PWallet -= 1000;
                jack += 1000;
                label11.Text = ("₽" + jack.ToString("N2"));
                label13.Text = PWallet.ToString("C2");
            }
            else
            {
                MessageBox.Show("Нет денег", "Пустойкошелёк", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}