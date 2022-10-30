Solution Name: WestPharma

Layers and corresponding Modules:


...........................................Project.....................................................

Common: (Contains configs, cshtmls which are common for all sites)

WestPharmaEU Brand: Specific to PharmaEU brand 

WestPharmaUS Brand: Specific to PharmaUS brand


...........................................Feature.....................................................

Accounts: Used to create and modify the account details specific to application.

FeedImport: Used to get feed details from an external API. 
			 Reference is added to Foundation.ExteranlWebRequest and common JSONGET and JSONPOST APIs are called from foundation layer.

Search: Used to search and get data. Index init. and predicate build is done here. 
		It refers Indexing from Foundation layer and uses that to fetch items from index.

Slider (Task 2:) Slider is a feature which have multiple slides and can be added as a component in a page.
	Slide item will have text, image and url fields and all fields are editable from the exp. editor. 
	Restrictions are in place for the place-holder and insert options to ensure items of corrrect templates are used while content creation.
	(Templates, Placeholders, rendering and sample page can be found in the Package attached in /Common folder)


...........................................Foundation.....................................................

Accounts: Used to do get profile image details from db. Common code and can be utilized by all brands.

Indexing: Used to fetch details from index for generic types. Feature module can prepare the predicate, mention the search result model
	and call this method to fetch details from index.

ExternalWebRequests: Used to perform REST API calls with external URLs. Used by FeedImport module to make web requests as GET/POST methods.
