
using Lexicon_uppgift3;

PersonHandler person = new PersonHandler();

Person person1 = person.CreatePerson(25, "Martin", "Paul", 177, 70);

person.setLname(person1, "NotPaul");

Console.WriteLine($" Testing! \n Name: {person1.fName} {person1.lName} \n Age: { person1.Age} ");



    List<UserError> errors = new List<UserError>();

    NumberError numberError = new NumberError();
    NumericInputError numericInputError = new NumericInputError();
    TextInputError textInputError = new TextInputError();

    errors.Add(numberError);
    errors.Add(numericInputError);
    errors.Add(textInputError);

    foreach (UserError error in errors)
    {
        Console.WriteLine($"Error: {error.UEMessage()}");
    }
