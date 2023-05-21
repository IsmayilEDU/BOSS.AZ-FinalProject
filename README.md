# BOSS.AZ-FinalProject

Ilk once sizi anamenyu qarshilayacaq
	Admin
		Login ve parol istenilecek. Login : admin, Password: admin.
		Daxil olduqdan sonra sizi Admin menyusu qarshilayacaq.
		
		Delete employer by ID:
			Sizi employerlerin ID-leri olan menyu qarshilayacaq. Siz hansi ID secsez,
			Hemin ID-ye malik employer vakansiyalari ile birge silinecek.
		
		Delete JobSeeker by ID:
			Sizi jobseekerlerin ID-leri olan menyu qarshilayacaq. Siz hansi ID secsez,
			Hemin ID-ye malik jobseeker oz CV-si ile birge silinecek.

		İncrease Month Of Vacancy By ID:
			Sizi butun vakansiyalarin ID-leri olan menyu qarshilayacaq. Siz hansi ID secsez,
			Hemin ID-ye malik vakansiyanin bitme vaxti 1 ay uzadilacaq.

		Make CV Premium By ID:
			Sizi butun CV-lerin ID-leri olan menyu qarshilayacaq. Siz hansi ID secsez,
			Hemin ID-ye malik CV premium olacaq

		Make Vacancy Premium By ID:
			Sizi butun vakansiyalarin ID-leri olan menyu qarshilayacaq. Siz hansi ID secsez,
			Hemin ID-ye malik vakansiya premium olacaq

	Employer

		Sign in
			Siz eger qeydiyyatdan kecmisinizse, burdan girish ede bilersiniz.
			Ad ve soyad istenilecek. Sonra Employer menyu qarshilayacaq sizi

		Sign up
			Siz qeydiyyatdan kecmeye bashlayacaqsiniz. Sizden istenilenler ve shertleri ashagidaki kimidir:
	
			Ad, Soyad, Sheher - Ancaq herflerden ibaret ola biler.
			Yash - 18-den yuxari olmalidir.
			Nomre - (050-555-55-55) <-- numune.
			Email - daxil etdikden sonra tesdiqleme kodu gelecek. Duzgun yazildiqda email tesdiq olunacaq.
			
			Vakansiyalarin sayi - musbet eded olmalidir.
			Vakansiyanin kateqoriyasi, sheheri - ancaq herf ola biler.
			Maash, ish tecrubesi (il ile) - musbet eded olmalidir.
			Shertler duz olmasa ERROR atilacaq ve yeniden daxil etmelisiniz.
			Sonra Employer menyu qarshilayacaq sizi

		Employer Menu

			Add vacancy
				Yeni vakanciya yaradilib. Employerin vakasiyalarina ve umumi vakansiyalara elave olunacaq.

			Apply Admin For Make Increase Time Of Vacancy
				Sizi vakansiyalarin ID-leri olan menyu qarshilayacaq. Siz hansi ID secsez,
				Hemin ID-ye malik vakansiyanin bitme vaxtinin 1 ay uzadilmasi haqqinda teleb email vasitesile 
				admine email gonderilecek.

			Apply Admin For Make Premium Vacancy
				Sizi vakansiyalarin ID-leri olan menyu qarshilayacaq. Siz hansi ID secsez,
				Hemin ID-ye malik vakansiyanin premium ounmasi haqqinda teleb email vasitesile 
				admine email gonderilecek.

			Remove Vacancy by ID
				Sizi employerin vakansiyalarin ID-leri olan menyu qarshilayacaq. Siz hansi ID secsez,
				Hemin ID-ye malik vakansiya silinecek

			Show all jobseekers
				Siz bura daxil olaraq butun ish axtaranlarin CV-lerine baxa bilersiniz.
				<-- ve --> oxlar vasitesile bir-bir CV-leri geze bilersiniz.
				ENTER vasitesile ona muraciet ede bilersiniz. (email gonderilecek)
				ESC vasitesile buradan chixa bilersiniz.

	Jobseeker
		Sign in
			Siz eger qeydiyyatdan kecmisinizse, burdan girish ede bilersiniz.
			Ad ve soyad istenilecek. Sonra Jobseeker menyu qarshilayacaq sizi

		Sign up
			Siz qeydiyyatdan kecmeye bashlayacaqsiniz. Sizden istenilenler ve shertleri ashagidaki kimidir:
			
			Ad, Soyad, Sheher - Ancaq herflerden ibaret ola biler.
			Yash - 18-den yuxari olmalidir.
			Nomre - (050-555-55-55) <-- numune.
			Email - daxil etdikden sonra tesdiqleme kodu gelecek. Duzgun yazildiqda email tesdiq olunacaq.

			Profession - ancaq herflerden ibaret ola biler.
			University Diplom - 'yes' ve ya 'not' daxil etmelisiniz.

			Dil bilikleri
			Sayi - musbet olmalidir
			Ilk once dil, sonra bildiyiniz seviyyeni daxil etmelisiniz.
			
			Ish tecrubeleri
			Sayi - menfi ola bilmez.
			Ishlediyiniz shirketin adi adi - ancaq herflerden ibaret ola biler.
			Hemin shirketde oldugunuz pozisiya - ancaq herflerden ibaret ola biler.
			Bashlangic tarixi ve ishden cixish vaxti

		Jobseeker Menu
	
			Apply To Admin For Make Premium CV
				Admine email gedecek ki CV premium edilsin.

			Change CV
				Oz CV-nizi deyishdire bilersiniz.

			Show All Vacancies
				Siz bura daxil olaraq butun vakansiyalara  baxa bilersiniz.
				<-- ve --> oxlar vasitesile bir-bir vakansiyalari geze bilersiniz.
				ENTER vasitesile ona muraciet ede bilersiniz. (employere email gonderilecek)
				ESC vasitesile buradan chixa bilersiniz.

	Qeyd: ETDIYINIZ DEYISHIKLIKLER YADDA SAXLANILMAGINI ISTEYIRSINIZSE, ANA MENYUDA EXIT SECMELISINIZ.
	

	


