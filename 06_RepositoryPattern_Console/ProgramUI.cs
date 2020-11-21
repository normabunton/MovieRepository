using _06_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_RepositoryPattern_Console
{
    class ProgramUI
    {
        private StreamingContentRepository _contentRepo = new StreamingContentRepository();


        //Method that runs/or starts the application
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        //Menu
        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {
                //Display our options to the user
                Console.WriteLine("Select a Menu Option:\n" +
                    "1. Creat New Content\n" +
                    "2. View All Content\n" +
                    "3. View COntent by Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing COntent\n" +
                    "6. Exit");

                //Get users input

                string input = Console.ReadLine();


                //evaluate the users input and act accordingly

                switch (input)
                {
                    case "1":
                        //Create new content
                        CreateNewContent();
                        break;
                    case "2":
                        //View All Content
                        DisplayAllContent();
                        break;
                    case "3":
                        //View Content by Title
                        DisplayContentByTitle();
                        break;
                    case "4":
                        //Update Existing Content
                        UpdateExistingContent();
                        break;
                    case "5":
                        //Delete Existing Content
                        DeleteExistingContent();
                        break;
                    case "6":
                        //Exit
                        Console.WriteLine("Goodbye");
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Please press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        //create new streaming content
        private void CreateNewContent()
        {
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("Enter the Title for the content:");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the Description for the content: ");
            newContent.Description = Console.ReadLine();

            //MaturityRating
            Console.WriteLine("Enter the rating for the content (G, PG, PG-13, R): ");
            newContent.MaturityRating = Console.ReadLine();

            //StarRating
            Console.WriteLine("Enter the Star Count for the content:");
            string starsAsString = Console.ReadLine();
            newContent.StarRating = double.Parse(starsAsString);

            //ISFamilyFriendly
            Console.WriteLine("Is this family friendly content?");
            string familyFriendlyString = Console.ReadLine().ToLower();
            if(familyFriendlyString == "y")
            {
                newContent.IsFamilyFriendly = true;
            }
            else
            {
                newContent.IsFamilyFriendly = false;
            }

            //GenreType

            Console.WriteLine("Enter the Genre NUmber: \n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. SciFi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n");

            string genreAsString = Console.ReadLine();
            int genreAsInt = int.Parse(genreAsString);
            newContent.TypeOfGenre = (GenereType)genreAsInt;

            _contentRepo.AddContentToList(newContent);
}


//view current streaming content that is saved
private void DisplayAllContent()
{
            List<StreamingContent> listofCOntent = _contentRepo.GetContentList();

            foreach(StreamingContent content in listofCOntent)
            {
                
            }
}

//view existing content by title
private void DisplayContentByTitle()
{
            Console.Clear();
            ///prompt the user to give me a title
            Console.WriteLine("Enter the title of the content you would like to see: ");

            //Get the users input
            string title = Console.ReadLine();

            //Find the content by that title
            StreamingContent content = _contentRepo.GetContentByTitle(title);

            //Display said content if it isn't null
            if(content != null)
            {
                Console.WriteLine($"Title: {content.Title}\n," +
                                    $"Description: {content.Description}\n" +
                                    $"Maturity Rating: {content.MaturityRating}\n" +
                                    $"Stars: {content.StarRating}\n" +
                                    $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                                    $"Genre: {content.TypeOfGenre}");
            }
            else
            {
                Console.WriteLine("No content by that title.");
            }
}
//Update existing content

private void UpdateExistingContent()
{
            //Display all Content
            DisplayAllContent();
            //Ask for the Title of the content to update
            Console.WriteLine("Enter the title of the content youd like to update:");

            //Get that title
            string oldTitle = Console.ReadLine();


            //We will build a new object
            private void CreateNewContent()
            {
                StreamingContent newContent = new StreamingContent();

                //Title
                Console.WriteLine("Enter the Title for the content:");
                newContent.Title = Console.ReadLine();

                //Description
                Console.WriteLine("Enter the Description for the content: ");
                newContent.Description = Console.ReadLine();

                //MaturityRating
                Console.WriteLine("Enter the rating for the content (G, PG, PG-13, R): ");
                newContent.MaturityRating = Console.ReadLine();

                //StarRating
                Console.WriteLine("Enter the Star Count for the content:");
                string starsAsString = Console.ReadLine();
                newContent.StarRating = double.Parse(starsAsString);

                //ISFamilyFriendly
                Console.WriteLine("Is this family friendly content?");
                string familyFriendlyString = Console.ReadLine().ToLower();
                if (familyFriendlyString == "y")
                {
                    newContent.IsFamilyFriendly = true;
                }
                else
                {
                    newContent.IsFamilyFriendly = false;
                }

                //GenreType

                Console.WriteLine("Enter the Genre NUmber: \n" +
                    "1. Horror\n" +
                    "2. RomCom\n" +
                    "3. SciFi\n" +
                    "4. Documentary\n" +
                    "5. Romance\n" +
                    "6. Drama\n" +
                    "7. Action\n");

                string genreAsString = Console.ReadLine();
                int genreAsInt = int.Parse(genreAsString);
                newContent.TypeOfGenre = (GenereType)genreAsInt;

                //verify the update worked

                bool wasUpdated = _contentRepo.UpdateExistingContent(oldTitle, newContent);

                if (wasUpdated)
                {
                    Console.WriteLine("Content successfully updated!");
                }
                else
                {
                    Console.WriteLine("Could not update content.")
                }

            }
//delete existing content
private void DeleteExistingContent()
{

            DisplayAllContent();

            //Get the title they want to remove
            Console.WriteLine("\nEnter the Title of the content you would like to remove:");

            string input = Console.ReadLine();

            //Call the delete method
            bool wasDeleted = _contentRepo.RemoveContentFromList(input);


            //If the content was deleted, say so
            if (wasDeleted)
            {
                Console.WriteLine("The content was successfully deleted.");

            }
            else
            {
                Console.WriteLine("The content could not be deleted");
            }

            //Otherwise state it could not be deleted

}

        //see method
        private void SeedContentList()
        {
            StreamingContent sharknado = new StreamingContent("Sharknado", "Tornados, but with sharks.", "TV_14", 3.3, true, GenreType.Action);
            StreamingContent theRoom = new StreamingContent("The Room", "Bankers life get turned upside down.", "R", 3.7, false, GenreType.Drama);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire comes to life and goes on a killing spree.", "R", 5.8, false, GenreType.Documentary);

            _contentRepo.AddContentToList(sharknado);
            _contentRepo.AddContentToList(theRoom);
            _contentRepo.AddContentToList(rubber);
        }
}
}
