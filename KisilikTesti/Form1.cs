namespace KisilikTesti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Visible = false;
            radioButton1.Visible = false;
            radioButton2.Visible = false;
            radioButton3.Visible = false;
            radioButton4.Visible = false;
            radioButton5.Visible = false;
            button1.Visible = false;
            button2.Visible=false;

        }
        int soru = 1;
        int puan = 0;
        string a = "Hi� Kat�lm�yorum";
        string b = "Kat�lm�yorum";
        string c = "Biraz Kat�l�yorum";
        string d = "Kat�l�yorum";
        string x = "Kesinlikle Kat�l�yorum";
        private void button1_Click(object sender, EventArgs e)
        {
            
            if (radioButton1.Checked == true)
            {
                puan = puan + 1;
                soru++;
            }
            else if (radioButton2.Checked == true)
            {
                puan = puan + 2;
                soru++;
            }
            else if (radioButton3.Checked == true)
            {
                puan = puan + 3;
                soru++;
            }
            else if (radioButton4.Checked == true)
            {
                puan = puan + 4;
                soru++;
            }
            else if (radioButton5.Checked == true)
            {
                puan = puan + 5;
                soru++;
            }
            else
            {
                MessageBox.Show("L�tfen soruyu cevaplay�n�z");
            }
            
            label3.Text = Convert.ToString(puan);            
            switch(soru)
            {
                case 1:
                    label1.Text = "1. Sabahlar� ne�eli bir �ekilde uyan�r�m.";
                    break;
                case 2:
                    label1.Text = "2. �o�unlukla ne�em yerindedir.";
                    break;
                case 3:
                    label1.Text = "3. �o�u kimse taraf�ndan sevilirim.";
                    break;
                case 4:
                    label1.Text = "4. Aynaya bakt���m zaman, aynada g�rd�klerim ho�uma gider.";
                    break;
                case 5:
                    label1.Text = "5. E�er kar�� cinsten biri olsayd�m kendimi �ekici bulurdum.";
                    break;
                case 6:
                    label1.Text = "6. Zeki bir insan�m.";
                    break;
                case 7:
                    label1.Text = "7. ��imden ho�lan�r�m.";
                    break;
                case 8:
                    label1.Text = "8. Kendimle ilgili olarak utan�lacak pek bir �ey g�remiyorum.";
                    break;
                case 9:
                    label1.Text = "9. Arkada�lar�m�n say�s� y�n�nden i�im rahat";
                    break;
                case 10:
                    label1.Text = "10. Olduk�a enerjik bir insan�m.";
                    break;
                case 11:
                    label1.Text = "11. Esas olarak iyimser bir ki�iyim.";
                    break;
                case 12:
                    label1.Text = "12. Kendi hatalar�ma g�lebilirim.";
                    break;
                case 13:
                    label1.Text = "13. E�er ya�ama yeniden ba�lama olana��m olsayd�,\n de�i�tirmek istedi�im pek bir �ey olmazd�.";
                    break;
                case 14:
                    label1.Text = "14. Ben ilgin� bir insan�m.";
                    break;
                case 15:
                    label1.Text = "15. Cinsel ya�am�mdan memnunum.";
                    break;
                case 16:
                    label1.Text = "16. Hala geli�en ve de�i�en bir insan�m.";
                    break;
                case 17:
                    label1.Text = "17. Ba�kalar� bana �nem verir,";
                    break;
                case 18:
                    label1.Text = "18. Bana benzer ba�ka insan pek bulunmaz.";
                    break;
                case 19:
                    label1.Text = "19. G�r�n���mle ilgili olarak de�i�tirmek istedi�im bir �ey yok.";
                    break;
                case 20:
                    label1.Text = "20. Ben duyarl� bir insan�m.";       
                    break;
                case 21:
                    label1.Text = "21. �imdiye dek yapt�klar�mdan pi�man de�ilim.";             
                    break;
                case 22:
                    label1.Text = "22. �nem verdi�im ki�iler benim g�r�� ve d���ncelerimle ilgilenirler.";
                    break;
                case 23:
                    label1.Text = "23. Duygular�m� a��klamaktan �ekinmem.";             
                    break;
                case 24:
                    label1.Text = "24. Ger�ekten bir cennet varsa, �ld�kten sonra ben mutlaka oraya giderim.";
                    break;
                case 25:
                    label1.Text = "25. Ba�kalar�yla konu�urken rahat�m.";            
                    break;
                case 26:
                    label1.Text = "26. Ya�am�m� istedi�im y�ne �evirebilirim.";             
                    break;
                case 27:
                    label1.Text = "27. Yerinde olmak istedi�im, g�ptayla bakt���m pek kimse yok.";                
                    break;
                case 28:
                    label1.Text = "28. Olduk�a ilgin� bir ya�am s�rd�m.";                  
                    break;
                case 29:
                    label1.Text = "29. Ben her t�rl� iyilik ve �d�le de�er biriyim.";                    
                    break;
                case 30:
                    label1.Text = "30. Ya�am�mda �u anda bulundu�um noktada olmaktan memnunum.";
                    button1.Text = "Bitir";
                    break;
                case 31:
                    if(puan<=47)
                    {
                        MessageBox.Show("Testi tamamlad�n! Puan�n: "+puan+"\nSonu�: 47 ve a�a��s�\nKendinizi pek seven bir insan de�ilsiniz. Belki de ge�ici olarak kendinizi a�a��lama d�neminde bulunuyorsunuz. Herkes b�yle bir d�nemden ara s�ra ge�er.");
                        label1.Visible = false;
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        radioButton5.Visible = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        button1.Visible = false;
                        button2.Visible = true;
                    }
                    else if (puan > 47 && puan <= 71)
                    {
                        MessageBox.Show("Testi tamamlad�n! Puan�n: "+puan+"\nSonu�; 48-71 aras�\nKendinizle ilgili karma��k duygular�n�z var. Baz� g��l� y�lerinizin fark�ndas�n�z, ancak zay�f y�nlerinizi g�z�n�zde daha �ok abart�yor olabilirsiniz.");
                        label1.Visible = false;
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        radioButton5.Visible = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        button1.Visible = false;
                        button2.Visible = true;
                    }
                    else if (puan > 71 && puan <= 95)
                    {
                        MessageBox.Show("Testi tamamlad�n! Puan�n: "+puan+"\nSonu�: 72-95 aras�\nKendini seven ve kendiyle bar���k olan insanlardan birisiniz. M�kemmel olmad���n�z� bildi�iniz halde, kar��la�t���n�z bireysel sorunlar� ��zebilecek inanc� kendinizde bulabiliyorsunuz.");
                        label1.Visible = false;
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        radioButton5.Visible = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        button1.Visible = false;
                        button2.Visible = true;
                    }                    
                    else if (puan > 95)
                    {
                        MessageBox.Show("Testi tamamlad�n! Puan�n: "+puan+"\nSonu�: 96 ve yukar�s�\nKendiniz hakk�nda olduk�a olumlu d���nen bir insans�n�z. Ama e�er puan�n�z 105'in �zerindeyse, herhalde i�i biraz �akaya vurdunuz. E�er kendinizi bu denli be�enmi� biri iseniz ili�kilerinizde insanlar� ka��r�yor olabilirsiniz.");
                        label1.Visible = false;
                        radioButton1.Visible = false;
                        radioButton2.Visible = false;
                        radioButton3.Visible = false;
                        radioButton4.Visible = false;
                        radioButton5.Visible = false;
                        radioButton1.Checked = false;
                        radioButton2.Checked = false;
                        radioButton3.Checked = false;
                        radioButton4.Checked = false;
                        radioButton5.Checked = false;
                        button1.Visible = false;
                        button2.Visible = true;
                    }
                    break;


            }
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "1. Sabahlar� ne�eli bir �ekilde uyan�r�m.";
            button1.Visible = true;            
            label2.Visible = false;
            radioButton1.Text = a;
            radioButton2.Text = b;
            radioButton3.Text = c;
            radioButton4.Text = d;
            radioButton5.Text = x;
            button3.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Text = "Sonraki";
            soru = 1;
            puan = 0;
            label1.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            radioButton4.Visible = true;
            radioButton5.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            label1.Text = "1. Sabahlar� ne�eli bir �ekilde uyan�r�m.";
            button1.Visible = true;
            label2.Visible = false;
            radioButton1.Text = a;
            radioButton2.Text = b;
            radioButton3.Text = c;
            radioButton4.Text = d;
            radioButton5.Text = x;
            button3.Visible = false;
            button2.Visible = false;
        }
    }
}