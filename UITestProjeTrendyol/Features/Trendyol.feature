Feature: Trendyol


Scenario: SepeteUrunEkle
	* Google Chrome Tarayıcısı açılır ve 'https://www.trendyol.com/' adresine girilir
	* Popup Kapatılır
	* Giriş Yap butonuna tıklanır
	* E-Posta adresi alanı 'test@test.com' girilir
	* Şifre alanı '123test123' girilir
	* Giriş Yap butonuna basılır
	* Arama alanına 'bilgisayar' yazılır
	* Arama butonuna tıklanır
	* İlk ürüne tıklanır
	* Ürün Sepete eklenir
	* Sepete Tıklanır
	* Ürünün Sepette Olduğu Kontrol edilir

Scenario: SepettenUrunCikar

	* Google Chrome Tarayıcısı açılır ve 'https://www.trendyol.com/' adresine girilir
	* Popup Kapatılır
	* Giriş Yap butonuna tıklanır
	* E-Posta adresi alanı 'test@test.com' girilir
	* Şifre alanı '123test123' girilir
	* Giriş Yap butonuna basılır
	* Sepete Tıklanır
	* Sepetten Ürün Silinir