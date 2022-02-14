1-Form1==> AnaSayfa olarak yeniden adlandırıkldı.
2-AnaSayfanın icine TabControl eklendi en uste konuslandırıldı.
3-TabControlun TabPage1->Genel yazildi TabPage2->Yonetim yazildi.
4-Splitter ekledik propery den ayarlarini yaptık.
5-Panel ekledik sola yasladik.
6-splitter ekledik onuda panele yasladik.
7-ortaya bir panel ekledik icine textbox,label ve 2 tane button ekledik ayarlarini property den yaptiktan sonra sola yaslanan panelin icine tasidik.
8-soldaki panelin icine splitterContainer ekledikn property yaptik panel1 treeView ekledik property den ayarini yaptık.panel2 ye buton ekldik.
9-Anasayfa property sinde isMdiContainer özelligini true yaptik.
10-Code tarafında gecmek icin AnaSyfa form a cift tıkladık.
11-Bilgi giris icin olusturulan butona cift tıklayarak kod tarafında click event metodunu olusturduk.
12-lblMenu.text nin icine butonun text ni gonderdik.
13-Menu olustur() metodunu yazdık hata veren bu kodun uzerinde sag click yapıp bu metodun generete edilmesini sagladık.
14-Menu olustur metodunun icinde tvMenu icinde olusması gereken nodes leri yazdık.
15-Bilgi işlemdeki diğer formlarıda oluşturduk 
16-ardından db bağlantısı yaptık
17-ardından iki tane yeni tablo oluşturduk ve içirisine o an aklımıza gelen tabloda olması gerekn isimleri verdik
18-her iki tabloda da bir primary key belirlendi ve ıdentty spesification özelliği true yapıldı
19-ardından iki tablo arasındaki forengkey bağlantısı yapıldı
20-tüm tablo işlemlerinden sonra update edilmesi gerekiyor yoksa yaılan değişikler kaydedilmemiş oluyor.
21-hastene tiplerini tablo olrak sgl le programım arsında köprüyü kurduk
22-sp conteiner ekledik ardından panel2 ye datagridview ekledik
23-panel 1 e label textbox combobox richtextbox ekledik ve ana iskeletimizi oluşturduk
24-sgl şehirler tablosu ekledik ve hasteler tablosuyla forengkey yaptık ve hastaneler tablosunu güncelledik
25-btnkaydet butonunun click özelliğini kullanarak içine bir yenikayıt() adında fonksiyon tanımladık ve bu fonksiyonun içine tblHastaneler hst=new tblHastaneler(); hst nesnesini üretip onun özelliklerini kullanarak textden aldığımız verileri hastane tablosuna ekledik
26-ardından temizle diye bir metod oluşturup textleri vb. temizledik