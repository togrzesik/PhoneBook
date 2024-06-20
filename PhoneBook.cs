using System;

namespace PhoneBook
{
    class PhoneBook
    {
        public List<Contact> Contacts {get; set;} = new List<Contact>();
        public void AddContact(Contact contact){
            Contacts.Add(contact);
        }
        private void DisplayContactDetails(Contact contact){
            Console.WriteLine($"{contact.Name},{contact.Number}");
        }
        public void DisplayContact(string number){
            var contact = Contacts.FirstOrDefault(c => c.Number == number);

            if(contact==null){
                Console.WriteLine("Contact not found");
            }
            else{
                DisplayContactDetails(contact);
            }
        }

        public void DisplayAllContats(){
            foreach(var contact in Contacts)
            {
                DisplayAllContats(contact);
            }
        }

        public void SearchContacts(string searchPhrase){
            var searchContacts = Contacts.Where(c => c.Name.Contains(searchPhrase).ToList());
            foreach(var contact in matchingContacts)
            {
                DisplayAllContats(contact);
            }
        }
    }
}