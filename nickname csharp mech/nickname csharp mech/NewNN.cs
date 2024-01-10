using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace nickname_csharp_mech
{
    public partial class NewNN : Form
    {
        char[] NUMS = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public NewNN()
        {
            InitializeComponent();
        }

        private void BackExistButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CopyExistButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NewResultTB.Text);
        }

        private int min(int one, int two)
        {
            if (one < two)
            {
                return one;
            }
            return two;
        }

        private int max(int one, int two)
        {
            if (one > two)
            {
                return one;
            }
            return two;
        }
        int COUNT_OBJ;
        int COUNTT_ADJ;
        string[] ADJS;
        string[] OBJS;
        private void NNFromFiles(ref string s)
        {
            try
            {
                using (StreamReader input = new StreamReader("adJ_for_newNN.txt")) /*("test_adj.txt"))*/
                {
                    using (StreamReader input_obj = new StreamReader("obj_for_newNN.txt")) /*("test_obj.txt"))*/
                    {
                        COUNTT_ADJ = int.Parse(input.ReadLine());//количество прилагательных в первой строке
                        COUNT_OBJ = int.Parse(input_obj.ReadLine());//количество существительных в первой строке
                        ADJS=new string [COUNTT_ADJ];
                        OBJS=new string[COUNT_OBJ];
                        int min_count = min(COUNTT_ADJ, COUNT_OBJ);
                        int max_count = max(COUNTT_ADJ, COUNT_OBJ);
                        for (int i = 0; i < COUNTT_ADJ; i++)
                        {
                            ADJS[i] = input.ReadLine();
                            OBJS[i] = input_obj.ReadLine();
                        }
                        if (max_count != min_count)
                        {
                            if (min_count == COUNTT_ADJ)
                            {
                                for (int j = min_count; j <= (max_count - min_count); j++)
                                {
                                    OBJS[j] = input_obj.ReadLine();
                                }
                            }
                            else
                            {
                                for (int j = min_count; j < (max_count - min_count); j++)
                                {
                                    ADJS[j] = input.ReadLine();
                                }
                            }
                        }


                    }
                }
            }
            catch (FileNotFoundException)
            {
                
                s = "Файл не найден!";
            }
            catch
            {
               
                s = "Ошибка!";
            }
        }

        private string generate1_algo(ref string s)
        {
            Random Rand;
            Rand = new Random();
            int num_of_adj = Rand.Next(0, COUNTT_ADJ-1);
            int num_of_obj = Rand.Next(0, COUNT_OBJ-1);
            string adj = ADJS[num_of_adj];
            string obj = OBJS[num_of_obj];
            s = adj + obj;
            return s;
        }

        private string to_lower(ref string temp)
        {
            char[] charArray = temp.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (char.IsLetter(charArray[i]) && char.IsUpper(charArray[i]))
                {
                    charArray[i] = char.ToLower(charArray[i]);
                }
            }

            temp = new string(charArray);
            return temp;
        }

        private string generate2_algo(ref string s)
        {
            Random Rand;
            Rand = new Random();
            int num_of_adj = Rand.Next(0, COUNTT_ADJ - 1);
            int num_of_obj = Rand.Next(0, COUNT_OBJ - 1);
            string adj = ADJS[num_of_adj];
            string obj = OBJS[num_of_obj];
            adj = to_lower(ref adj);
            obj = to_lower(ref obj);
            s = adj + "_" + obj;
            return s;
        }

        private string generate3_algo(ref string s)
        {
            Random Rand;
            Rand = new Random();
            int num_of_adj = Rand.Next(0, COUNTT_ADJ - 1);
            int num_of_obj = Rand.Next(0, COUNT_OBJ - 1);
            string adj = ADJS[num_of_adj];
            string obj = OBJS[num_of_obj];
            adj = to_lower(ref adj);
            obj = to_lower(ref obj);
            int num_of_rand_symb = Rand.Next(0, NUMS.Length - 1);
            char rand_symb = NUMS[num_of_rand_symb];
            s = rand_symb + adj + "_" + obj + rand_symb;
            return s;
        }

        private string generator_one()
        {
            string s = "";
            NNFromFiles(ref s);
            if ((s!= "Файл не найден!") ||(s!= "Ошибка!"))
            {
                s = "";
                generate1_algo(ref s);
            }
            return s;
        }

        private string generator_two()
        {
            string s = "";
            NNFromFiles(ref s);
            if ((s != "Файл не найден!") || (s != "Ошибка!"))
            {
                s = "";
                generate2_algo(ref s);
            }
            return s;
        }

        private string generator_three()
        {
            string s = "";
            NNFromFiles(ref s);
            if ((s != "Файл не найден!") || (s != "Ошибка!"))
            {
                s = "";
                generate3_algo(ref s);
            }
            return s;
        }

        private void NewNNButton_Click(object sender, EventArgs e)
        {
            string result;
            if (NewNN1algoRB.Checked)
            {
                result = generator_one();
                NewResultTB.Text = result;
            }
            if (NewNN2algoRB.Checked)
            {
                result = generator_two();
                NewResultTB.Text = result;
            }
            if (NewNN3algoRB.Checked)
            {
                result = generator_three();
                NewResultTB.Text = result;
            }
        }
    }
}
