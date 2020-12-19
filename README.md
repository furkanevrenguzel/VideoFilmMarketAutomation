# VideoFilmMarketAutomation
   The purpose of my work called Video-Film Market automation is that I have movies or videos that I sell to my customers and all the information (Movies, Movie types, customers and sales.) I host on this automation. After that, I modeled my database table on paper and executed the database in the Sql Server Management Studio database program. My database will deal with a scenario like this, we have movies, and we have movie genres, and we have major customer groups, we sell our movies to these customers, and we sell our movies if we have them in stock. We also divide films into genres according to a certain classification. For example, a romantic movie, a thriller, an action movie, and so on. Each film of the film number, film title, film number, type, director, actors, summary, movie cover art and the amount; each type of film type of Film number, type, name and description; the customer number of each customer, customer name, last name, phone and address; the number of sales for every sale, date, Film number, customer number, amount and the unit price will be. After finishing database design, I started form Design and code writing in Microsoft Visual Studio.
  First, I added MenuStrip and created my menus movie definition and query submenu in the movies menu; movie type definition in the movie types menu; customer card and customer query in the customers menu; movie sales operations and sales query submenu in the sales menu, and we also created our menu for the exit process. We also give names to these menus; mnFilmler, mnFilmTurleri, mnmusteriler, mnsatislar and mncikis.
  As we can handle our operations in class label, we open a class in terms of the simple application that we will write. We're reaching out to the guy inside the class and doing our operations. We wrote the name as movies.then I created another class FilmTurler.I also created a new class for sales called Sales. I also created a class for customers customers. I created a class that will allow me to connect to SQL. I wrote public in my connection class because it allows access to the item in the program from anywhere. I will do these operations with windows to work in the local area. I created two more classes called Program and Control and wrote its codes, which form screen will open the first time I run the program in the Program class. In the control Class, I write characters that I don't want to have in my data entries. In the movies class, we will model all the fields in the movies table in the database. We don't want outside intervention, we'll do the first field, so we'll encapsulate the movies, we'll give private to the class, just from where it's defined, so we come to the columns in the code I wrote and encapsulate them all. So the Get set block comes out. I'll use them when I want to make changes. When we came to the FormAcikMi Code section, I wrote a method. The purpose of this is that since we will have more than one form, the structure that controls the state of opening and closing instead of opening them in a row should be in question. It's time for our cs extension form designs. 
Second, I made my form called Frmfilmtanimlama screen and wrote the necessary codes here is a scene that saves the movies in the database and contains their properties. I have written our codes FrmFilmSorgula. In this form, we can search our movies according to any registered feature. In my frmfilmtur forum, we define film types and descriptions.
  We enter customer information in my frmmusterislemler form and save it in the database, we perform customer query operations in the frmmusteris Request Form. Sales prices, customs, etc. on the frmsatis processes forum we're processing. In a form called FrmSatisTarihleri, I check which films I sold between which dates according to the sales dates. So I wrote the codes you need by creating these forms. I checked the missing location of all my forms in the code and fixed the missing or incorrect places. By running the forms one by one, I confirmed whether they were all active, whether the data added to one form was added to the data in the other form. This project is designed to meet the needs of a company that sells films. The overall aim of the project is to keep the company's customer records, the list of films in hand and the reports of the films sold. The project consists of films, film types, customers and sales sections. In the movies Section, new movies can be added, records of movies in the database can be listed or shown in detail, and the desired movie can be sent to other forms. In the movie types section, you can check whether the movie type is added to the movies table and add, delete, change, and save. 
  In addition to listing registered customers from the customers Section, new customers can be registered, displaying customer details and deleting customers. In the sales section, data is entered in the price and quantity of movie sales and which sales were made between which dates were checked. As a result, a program has been designed that can meet all the needs of a company for selling movies.

