PersonModel person =new PersonModel();
person.FirstName = "First Name: ".RequestString();
person.LastName = "Last Name: ".RequestString();
person.Age="Age: ".RequestInt(0,120);
person.NumberOfChildren = "Number of Children: ".RequestInt(0,2000);

