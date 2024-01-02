	• One issue is that HIFIS will be taking in several Volunteers who could have access to the personal information from logging in to HIFIS (The City of Ottawa does not want that).
	• The City wants the PIT survey external to the HIFIS internal admin main page post login but still saves information to the same database.
	• As put SIMPLY a survey with a way to track the volunteers and the people that log the information.
	• Jason will be updating the sample project DLLs to make the authentication easier.


How to install HIFIS: 

	1) Open this directory \HIFIS Project Files\HIFIS installs\CRVS2010CR6424_0-10010309.ZIP\CRforVS_redist_install_64bit_13_0_24
		a. Unzip
		b. Install prior to everything else 
		
	2) Open this directory  \HIFIS Project Files\HIFIS installs\HIFIS_DB_Complete(59_79).zip 
		a. To find the SQL scripts for the HIFIS database
		b. Use SQL Express to build all tables 
		
	3) Open this directory \HIFIS Project Files\HIFIS installs\HIFIS_4.0.59.7.zip 
		a. Unzip
		b. Steve mentioned to create a web application and drop HIFIS Domain and HIFIS Web in the Root
		
		c. \HIFIS Web\WebTemplate.config will need to updated based on instructions from the guide 
			i. Guide can be found in \HIFIS Web\HIFIS 4 - Updating 58 to 59 - Web webConfig Edits.pdf
		d. \HIFIS Web\DomainTemplate.config will need to updated based on instructions from the guide 
			i. Guide can be found in \HIFIS Domain\HIFIS 4 - Updating 58 to 59 - Domain webConfig Edits.pdf
		
	4) Installing HIFIS on a windows Server.
		a. Open HIFIS Project Files\HPD-Guide-Installation-EN_0.pdf 
			i. On page 23

   HIFIS Demo Site: https://demo.hifis.ca
   
   HIFIS Demo Site information: https://demo.hifis.ca/mvcdiagnostics.aspx
   
   Sample Application: https://github.com/jnlabbott/HIFIS_WCF_Sample

![image](https://github.com/ModestNacho/PIT-Survey/assets/102768902/e21811f1-15ac-4d95-a327-7fb8b5cad469)

