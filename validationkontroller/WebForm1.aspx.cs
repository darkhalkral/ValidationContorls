using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

    namespace vizeodev
    {
        public partial class WebForm1 : System.Web.UI.Page
        {
            protected void Page_Load(object sender, EventArgs e)
            {
                if (!IsPostBack)
                {
                    Labeletk.Text = "Form'un aktif olması için butona basınız";
                    Buttonetk.Text = "Aktif Et";
                    Label1.Text = "Ad";
                    Label2.Text = "Soyad";
                    Label3.Text = "Tc No";
                    Label4.Text = "Doğum Yeri";
                    Label5.Text = "Doğum Tarihi";
                    Label6.Text = "Yaşı";
                    Label7.Text = "Cinsiyeti";
                    Label8.Text = "Uyruğu";
                    Label9.Text = "E-mail";
                    Label10.Text = "E-mail tekrar";
                    Label11.Text = "Cep Telefonu";
                    Label12.Text = "Şifre";
                    Label13.Text = "Şifre Tekrar";
                    Label14.Text = "Butona Basarak Şifre Oluşturabilirsiniz";
                    Button1.Text = "Şifre Oluştur";
                    RegularExpressionValidator1.ControlToValidate = "TextBox1"; //Ad kısmına sadece alfabetik değer girileceği ve bunu kontrol edebilen tek validator olduğu için kullandım
                    RegularExpressionValidator2.ControlToValidate = "TextBox2"; //Soyad kısmına sadece alfabetik değer girileceği için kullandım
                    RegularExpressionValidator3.ControlToValidate = "TextBox3"; //Tc No kısmına sayı ama belirli bir şekilde ve aralarda çizgi olacak şekilde girileceğini kontrol ettiği için kullandım
                    RegularExpressionValidator4.ControlToValidate = "TextBox4"; //Doğum Yeri kısmına sadece alfabetik değer girileceği için kullandım
                    RangeValidator1.ControlToValidate = "TextBox5"; //Doğum tarihi kısmına girilen tarihin tarih formatında ve belirli değerler arasında olduğunu kontrol ettiği için kullandım
                    RangeValidator2.ControlToValidate = "TextBox6"; //Yaşı kısmına girilen sayı değerinin belirli bir aralıkta olduğunu kontrol ettiği için kullandım
                    RegularExpressionValidator5.ControlToValidate = "TextBox7"; //Cinsiyeti kısmına girilen değerin istenilen karakter ve yazılış şeklinde olmasını kontrol ettiği için kullandım
                    RegularExpressionValidator6.ControlToValidate = "TextBox8"; //Uyruğu kısmına girilen değerin istenilen karakter ve yazılış şeklinde olmasını kontrol edebildiği için kullandım
                    RegularExpressionValidator7.ControlToValidate = "TextBox9"; //Email kısmına girilen değerin istenilen şekilde olmasını kontrol edebildiği için kullandım
                    CompareValidator1.ControlToValidate = "TextBox10"; //Girilen e-maille aynı olup olmadığını karşılaştırabildiği için kullandım
                    RegularExpressionValidator8.ControlToValidate = "TextBox11"; //Cep Telefonu kısmına girilen değerin istelilen şekilde olmasını kontrol edebildiği için kullandım
                    CompareValidator2.ControlToValidate = "TextBox12"; //Şifre kısmına girilen değerin labeldaki değerle aynı olup olmadığını karşılaştırabildiği için için kullandım
                    CompareValidator3.ControlToValidate = "TextBox13"; //Bi üst textboxa girilen değerle aynı olup olmadığını karşılaştırabildiği için kullandım
                    RegularExpressionValidator1.ErrorMessage = "Ad sadece alfabetik değerlerden oluşabilir"; //hata mesajlarını tanımladım
                    RegularExpressionValidator2.ErrorMessage = "Soyad sadece alfabetik değerlerden oluşabilir";
                    RegularExpressionValidator3.ErrorMessage = "Tc No 000-000-00-000 şeklinde yazılmalıdır";
                    RegularExpressionValidator4.ErrorMessage = "Doğum yeri sadece alfabetik değerlerden oluşabilir";
                    RangeValidator1.ErrorMessage = "Doğum Tarihi tarih formatında ve bugüne göre 18-25 yaşında olan birisi için girilmelidir";
                    RangeValidator2.ErrorMessage = "Yaş 18-25 arasında olmalıdır";
                    RegularExpressionValidator5.ErrorMessage = "Cinsiyet için sadece E ya da K harfi girilebilir";
                    RegularExpressionValidator6.ErrorMessage = "Uyruk için sadece T.C ya da Y.Ü karakterleri girilebilir";
                    RegularExpressionValidator7.ErrorMessage = "E-mail ad.soyad@***.***.** şeklinde olmalıdır";
                    CompareValidator1.ErrorMessage = "E-mailler aynı olmalıdır";
                    RegularExpressionValidator8.ErrorMessage = "Cep telefonu (0 5)00 000 00 00 şeklinde olmalıdır";
                    CompareValidator2.ErrorMessage = "Şifre Şifre Oluştur butonuna basılınca verilen değer olmalıdır";
                    CompareValidator3.ErrorMessage = "Şifreler aynı olmalıdır";
                    RegularExpressionValidator1.Display = ValidatorDisplay.None; //Hata mesajlarının form üzerinde dağınık bir şekilde gözükmesi yerine forma eklediğim ValidationSummaryde güzel bir şekilde gözükmesi için display özelliğini none yaptım
                    RegularExpressionValidator2.Display = ValidatorDisplay.None;
                    RegularExpressionValidator3.Display = ValidatorDisplay.None;
                    RegularExpressionValidator4.Display = ValidatorDisplay.None;
                    RangeValidator1.Display = ValidatorDisplay.None;
                    RangeValidator2.Display = ValidatorDisplay.None;
                    RegularExpressionValidator5.Display = ValidatorDisplay.None;
                    RegularExpressionValidator6.Display = ValidatorDisplay.None;
                    RegularExpressionValidator7.Display = ValidatorDisplay.None;
                    CompareValidator1.Display = ValidatorDisplay.None;
                    RegularExpressionValidator8.Display = ValidatorDisplay.None;
                    CompareValidator2.Display = ValidatorDisplay.None;
                    CompareValidator3.Display = ValidatorDisplay.None;
                    RangeValidator1.Type = ValidationDataType.Date; 
                    DateTime mindate = DateTime.Today.AddYears(-25); //bugünün tarihini aldıktan sonra add.years komutu ile -25 yaş ekleyip bundan 25 yıl öncesinin tarihini buldum
                    DateTime maxdate = DateTime.Today.AddYears(-18); //bugünün tarihini aldıktan sonra add.years komutu ile -18 yaş ekleyip bundan 18 yıl öncesinin tarihini buldum
                    RangeValidator1.MinimumValue = mindate.ToString().TrimEnd('0', ':'); //gelen değer datetime olduğu için sondaki saat olan 00:00:00 değerlerini çıkarttım
                    RangeValidator1.MaximumValue = maxdate.ToString().TrimEnd('0', ':');
                    RangeValidator2.Type = ValidationDataType.Integer;
                    RangeValidator2.MinimumValue = "18";
                    RangeValidator2.MaximumValue = "25";
                    CompareValidator1.ControlToCompare = "TextBox9";
                    CompareValidator3.ControlToCompare = "TextBox12";
                    RegularExpressionValidator1.ValidationExpression = @"[a-zA-Z]+";
                    RegularExpressionValidator2.ValidationExpression = @"[a-zA-Z]+";
                    RegularExpressionValidator3.ValidationExpression = @"\d{3}-\d{3}-\d{2}-\d{3}";
                    RegularExpressionValidator4.ValidationExpression = @"[a-zA-Z]+";
                    RegularExpressionValidator5.ValidationExpression = @"(E|K)"; //yüzyüze derste hocaya sorarak teyit ettiğim ya da yöntemini kullandım
                    RegularExpressionValidator6.ValidationExpression = @"((T\.C)|(Y\.Ü))";
                    RegularExpressionValidator8.ValidationExpression = @"\(0\s5\)\d{2}\s\d{3}\s\d{2}\s\d{2}";
                    TextBox1.AutoPostBack = true; //e-mail kontrolünde ad.soyad değerinin güncel tutulması için textbox1 ve 2 değerleri değiştiği zaman sayfa yenilenecek ve !is.postback in dışına yazılmış olan e-mail kontrol validationı güncellenecek.
                    TextBox2.AutoPostBack = true;
                    TextBox12.AutoPostBack = true;//şifre kontrolünde şifre oluşturan butonun altta validation özelliğini kapattığım için şifre yenilendiğinde sayfa da yenilenmesi için kullandım
                    Button1.CausesValidation = false; //textboxların boş olup olmadığının kontrolünü RequiredFieldValidator ile yaptığım için şifre oluşturma butonuna basınca hataları gösterip şifre oluşmasına engel olmasın diye bu özelliği false yaptım
                    Buttonetk.CausesValidation = false;
                    etkisiz(); // formun başlangıcında itemlerin enable özelliğini false yapmak için kısayol olarak ControlCollection nesnesini kullandım.
                    Buttondegis.Visible = false; //burada aynı değerlerin girilmemesini belirten label ve butonların görünür olmasını kapattım
                    Buttonsıfırla.Visible = false;
                    Buttondegis.Text = "Değiştir";
                    Buttonsıfırla.Text = "Sıfırla";
                    Label15.Text = "";
                }
                CompareValidator2.ValueToCompare = Label14.Text;//postbackten etkilenip her seferinde yenilensin diye buraya yazdım.
                string adsoyad = TextBox1.Text + @"\." + TextBox2.Text; //yukarıda da belirttiğim gibi her seferinde güncellenmesi için dışarı yazdım. textbox değerlerini alıp ortasına . koydum .'yı @\. şeklinde belirtmemin sebebi aşağıda expression kısmına girecek olduğu için
                RegularExpressionValidator7.ValidationExpression= adsoyad + @"@\w{3}\.\w{3}\.\w{2}"; //ad.soyadı aldıktan sonra @ işareti 3 değer . 3 değer . 2 değer olmak üzere kodlamasını yazdım
            
                for (int i = 1; i <= 13; i++)//textboxların boş olup olmamasını kontrol eden ve döngü ile yazılan kısım
                {
                    RequiredFieldValidator kontrol = new RequiredFieldValidator(); //RequiredField itemini oluşturur.
                    kontrol.ID = "kontrol" + i.ToString(); //iteme id verir
                    kontrol.ControlToValidate = "TextBox" + i.ToString(); //itemin kontrol ettiği textbox nesnesini verir.
                    kontrol.ErrorMessage = i.ToString() + ". TextBox Boş Bırakılamaz"; //hata mesajı belirtir
                    kontrol.Display = ValidatorDisplay.None; //Hatayı validationsummary'de göstereceksek bu şekil saklayabiliriz.
                    form1.Controls.Add(kontrol); //sayfamızın kontrollerine ekliyoruz. Page.Controls diye değil htmlde ki form etiketinin ismine göre yani form1.Controls verdim
                }
            }
            protected void Button1_Click(object sender, EventArgs e)
            {
                    string sifre = "";
                    Random rastgele = new Random();
                    char karakter1 = Convert.ToChar(rastgele.Next(65, 91)); //rastgele değer oluştururken next komudu ASCII koduna göre ve ilk değeri dahil ikinci değeri hariç aldığı için Z değerinin +1i olan 91 yazarak Z ninde dahil olmasını sağladım
                    char karakter2 = Convert.ToChar(rastgele.Next(65, 91));
                    int karakter3 = rastgele.Next(0, 10);
                    int karakter4 = rastgele.Next(0, 10);
                    char karakter5 = Convert.ToChar(rastgele.Next(97, 123));
                    char karakter6 = Convert.ToChar(rastgele.Next(97, 123));
                    char karakter7 = Convert.ToChar(rastgele.Next(33, 48)); //ASCII koduna göre ilk ve son sembol değerlerini alıp yukarıdaki nedenden dolayı +1 ekleyerek son değerinde dahil olmasını sağladım
                    char karakter8 = Convert.ToChar(rastgele.Next(33, 48));
                    sifre = karakter1.ToString() + karakter2.ToString() + karakter3.ToString() + karakter4.ToString() + karakter5.ToString() + karakter6.ToString() + karakter7.ToString() + karakter8.ToString();
                    Label14.Text = sifre;
            }
            protected void Button2_Click(object sender, EventArgs e)
            {
                if (Page.IsValid)
                {
                    string deger = TextBox1.Text + " " + TextBox2.Text + " - " + TextBox3.Text + " _ " + TextBox4.Text + " - " + TextBox5.Text + " - " + TextBox6.Text + " - " + TextBox7.Text + " - " + TextBox8.Text + " - " + TextBox9.Text + " - " + TextBox11.Text + " - " + TextBox12.Text;
                    bool durum = false;
                    for (int i = 0; i < ListBox1.Items.Count; i++)//listboxta daha önceden o değer girilmiş mi diye kontrol ettim
                    {
                        int sıra1 = deger.IndexOf("_");//girilen degerlerde kolaylık sağlaması açısından Tc No'dan sonra _ koydum ve bunu kullanarak ad soyad ve Tc No'su substringle aldım
                        int sıra2 = ListBox1.Items[i].Value.IndexOf("_");
                        if (deger.Substring(0, sıra1) == ListBox1.Items[i].Value.Substring(0, sıra2))//eğer iki değer eşitse durum değişkenini true yaptım
                        {
                            durum = true;
                        }

                    }
                    if (durum)//durum değişkeni true ise label textine yazı yazdırıp, 2 butonu görünür yapıp diğerlerini etkisiz hale getirdim
                    {
                        Label15.Text = "Girmiş olduğunuz Ad Soyad ve Tc No daha önce girilmiş.<br>İsterseniz kaydı silip sıfırdan girebilir ya da kaydı değiştirebilirsiniz.";
                        Buttondegis.Visible = true;
                        Buttonsıfırla.Visible = true;
                        etkisiz();
                    }
                    else
                    {
                        ListBox1.Items.Add(deger);//durum değişkeni false ise degerleri listboxa ekleyip textboxları temizledim
                        temizle();
                    }
                
                }
            }
            protected void Buttonetk_Click(object sender, EventArgs e)
            {
                etkin();//itemleri etkinleştirip bunları görünmez yaptım
                Buttonetk.Visible = false;
                Labeletk.Visible = false;
            }
            protected void Buttonsıfırla_Click(object sender, EventArgs e)
            {
                temizle();//textboxları sıfırlayıp yeni butonları tekrardan görünmez yapıp, diğer itemleri etkin hale getirdim
                Label15.Text = "";
                Buttondegis.Visible = false;
                Buttonsıfırla.Visible = false;
                etkin();
            }
            protected void Buttondegis_Click(object sender, EventArgs e)
            {
                Label15.Text = "";//kullanıcıya değiştirmesi için fırsat verip butonları görünmez yapıp, diğer itemleri etkin hale getirdim.
                Buttondegis.Visible = false;
                Buttonsıfırla.Visible = false;
                etkin();
            }
            void etkisiz()
            {
                ControlCollection cc = form1.Controls; // Page.Controls diye değil htmlde ki form etiketinin ismine göre yani form1.Controls verdim
                foreach (Control item in cc)//burada kısayol olması amacıyla controlcollection yardımıyla textboxları etkisiz hale getirdim
                {
                    if (item is TextBox)
                        ((TextBox)item).Enabled = false;
                }
                Button1.Enabled = false;
                Button2.Enabled = false;
                ListBox1.Enabled = false;
            }
            void etkin()
            {
                ControlCollection cc = form1.Controls;//yukarıdakiyle aynı yoldan gidip itemleri etkinleştirdim
                foreach (Control item in cc)
                {
                    if (item is TextBox)
                        ((TextBox)item).Enabled = true;
                }
                Button1.Enabled = true;
                Button2.Enabled = true;
                ListBox1.Enabled = true;
            }
            void temizle()
            {
                ControlCollection cc = form1.Controls;//yukarıdaki yöntemle devam edip textboxları temizledim
                foreach (Control item in cc)
                {
                    if (item is TextBox)
                        ((TextBox)item).Text = "";
                }
                Label14.Text = "Butona Basarak Şifre Oluşturabilirsiniz";
            }
        }
    }