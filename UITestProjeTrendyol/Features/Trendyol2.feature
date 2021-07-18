Feature: Trendyol2


Background: 
	* Google Chrome Tarayıcısı açılır ve 'https://www.trendyol.com/' adresine girilir
	* Popup Kapatılır
	* Giriş Yap butonuna tıklanır
	* E-Posta adresi alanı 'test@test.com' girilir
	* Şifre alanı '123test123' girilir
	* Giriş Yap butonuna basılır

Scenario Outline: SepeteUrunEkle
	
	* Arama alanına '<search>' yazılır
	* Arama butonuna tıklanır
	* İlk ürüne tıklanır
	* Ürün Sepete eklenir
	* Sepete Tıklanır
	* Ürünün Sepette Olduğu Kontrol edilir
	Examples: 
	|search|
	|bilgisayar|
	|telefon|

Scenario: SepettenUrunCikar

	* Sepete Tıklanır
	* Sepetten Ürün Silinir