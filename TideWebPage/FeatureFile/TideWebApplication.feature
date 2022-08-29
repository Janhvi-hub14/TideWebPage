Feature: TideWebApplication
	Tide web application features

@ValidSignUP
Scenario: SignupWithValidDetails
	Given website link
	When user click on register button
	And user click on SIGN UP button 
	And user enters the valid Username ,Email ID,Password
	And Click on SignUp
	Then it should create accoun for user


@InvalidSignUp
Scenario: SignupWithInValidDetails
	Given website link open
	When user have to click on register button
	And user have to click on SIGN UP button 
	And user enters the Invalid Username ,Email ID,Password
	And user have to Click on SignUp
	Then it should not create account for user and should display error message


@ValidLogin
Scenario: LoginWithValidDetails
	Given open website link
	When user should click on register button
	And user click on LOGIN button 
	And user enters the Valid Email ID ,Password
	And Click on Login button
	Then it should Login to user Account

@InvalidLogin
Scenario: LoginWithInValidDetails
	Given open webpage
	When click on register button
	And click on LOGIN button 
	And user enters the Valid Email ID & InvalidPassword
	And user Click on Login button
	Then it should not Login to user Account

@ContactUSFunction
Scenario: Contactus
	Given browse Url
	When click on contact us
	Then it should display user contact us options

@SearchBar
Scenario: SearchBox
	Given open webpage link
	When enter any product name in search bar
	And click search button
	Then It should display all the products related to the provided info in search bar


@WhatsNewFunction
Scenario: WhatsNew
	Given Goto webpage
	When click on whats new option
	And click on read more of any option present there
	Then it should Display the Information Regarding the selected option

@HowToWashCloths
Scenario: HowToWashCloths
	Given goto website link
	When hover the mouse on the how to wash cloths feature
	And click on how to Remove stains option
	And click on the read more option present under subfeature
	Then it should Display the Information Related to the selected option


@CouponsAndRewardsFunction
Scenario: CouponsAndRewards
	Given visit the website link
	When click on coupons and reward option
	And ClicK on save now 
	And the appllication should ask for login and then enter the login credentials 
	And click on login then cupon is saved in the profile
	Then cupon should be saved in the profile after logging into the web page


@ShopProduct
Scenario: ShopProducts
	Given visit webapplication
	When user hover on shop products 
	And user click on any option present in by type
	And user should click on any product availaible in the products
	Then click on the retailer button to see nearby retailers

@LanguageChange
Scenario: WebpageLanguageChange
	Given visit webpage by url
	When user click on language change dropdown button
	And select any language option from availaible options
	Then It should Display the web page into that language


