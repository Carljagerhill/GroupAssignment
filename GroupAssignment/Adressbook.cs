using System;
using System.Collections.Generic;
using System.Text;

namespace GroupAssignment
{
    class Adressbook
    {
        List<Person> AdressBookList = new List<Person>();

        public void UserChoice()
        {
            Console.WriteLine("Do you want to do? \n 1. Create New Contact \n 2. Edit Contact \n 3. Remove Contact \n 4. Find Person \n 5.List All Contacts \n type x and enter to close the application");
            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    CreatePerson();
                    break;

                case "2":
                    EditPersonInfo();
                    break;

                case "3":
                    RemovePersonFromList();
                    break;

                case "4":
                    FindPerson();
                    break;

                case "5":
                    ListAllContacts();
                    break;

                case "x":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid input");
                    break;
            }
        }
        public void CreatePerson()
        {
            int age;
            Console.WriteLine("Enter Name:");
            var name = Console.ReadLine().ToLower();

            while (true)
            {
                Console.WriteLine("Enter Age:");
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    break;
                }
                Console.WriteLine("Please enter a valid age");
            }

            Person person = new Person(name, age);
            AdressBookList.Add(person);
        }

        public void RemovePersonFromList()
        {
            Console.WriteLine("Who do you want to remove from your list?");
            var userInput = Console.ReadLine().ToLower();
            AdressBookList.RemoveAll(r => r.Name == userInput);
        }

        public void EditPersonInfo()
        {
            Console.WriteLine("Which person do you want to edit?");
            var userInput = Console.ReadLine().ToLower();
            Person person = AdressBookList.Find(f => f.Name == userInput);
            if (person != null)
            {
                Console.WriteLine($"What do you want to edit? \n 1. {person.Name}'s Name \n 2. {person.Name}'s Email Adress " +
               $"\n 3. {person.Name}'s Home Adress \n 4. {person.Name}'s Private Phone Number \n 5. {person.Name}'s Work Phone Number");
                var userInput1 = Console.ReadLine();
                switch (userInput1)
                {
                    case "1":
                        Console.WriteLine("Type the updated name");
                        var newValue = Console.ReadLine();
                        person.Name = newValue;
                        break;

                    case "2":
                        Console.WriteLine("Type the updated email");
                        var newEmail = Console.ReadLine();
                        person.EmailAdress = newEmail;
                        break;

                    case "3":
                        Console.WriteLine("Type the update adress");
                        var newAdress = Console.ReadLine();
                        person.HomeAdress = newAdress;
                        break;

                    case "4":
                        Console.WriteLine("Type the updated private phone number");
                        var newPrivatePhone = Console.ReadLine();
                        person.PrivatePhoneNumber = newPrivatePhone;
                        break;

                    case "5":
                        Console.WriteLine("Type the update work phone number");
                        var newWorkPhone = Console.ReadLine();
                        person.WorkPhoneNumber = newWorkPhone;
                        break;

                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Can't edit a person that doesn't exist");
            }

        }

        public void FindPerson()
        {
            Console.WriteLine("Search for ");
            var userInput = Console.ReadLine().ToLower();
            Person person = AdressBookList.Find(f => f.Name == userInput || f.HomeAdress == userInput
            || Convert.ToString(f.Age) == userInput || f.EmailAdress == userInput || f.PrivatePhoneNumber == userInput || f.WorkPhoneNumber == userInput);

            if (person != null)
            {
                Console.WriteLine($"{person.Name}, {person.Age}, {person.EmailAdress}, {person.HomeAdress}, {person.PrivatePhoneNumber}, {person.WorkPhoneNumber}");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("This person does not exist");
            }


        }

        public void ListAllContacts()
        {
            foreach (var person in AdressBookList)
            {
                Console.WriteLine($"{person.Name}, {person.Age}, {person.EmailAdress}, {person.HomeAdress}, {person.PrivatePhoneNumber}, {person.WorkPhoneNumber}");
            }
        }


    }
}
