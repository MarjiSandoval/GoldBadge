using System;
using _07_StreamingContent_Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _08_StreamingContent_Inheritence;

namespace _10_StreamingContent_UIRefactor.UI
{
    public class ProgramUI
    {

        private readonly IConsole _console;
        private readonly StreamingRepository _streamingRepo = new StreamingRepository();

        //Dependency Injection
        public ProgramUI(IConsole console)
        {
            _console = console;
        }


        public void Run()
        {

            SeedContent();
            RunMenu();
        }

        private void RunMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                _console.Clear();
                _console.WriteLine(
                    "Enter the number of the option you'd like to select: \n" +
                    "1. Show all Streaming content\n" +
                    "2. Find streaming content by title \n" +
                    "3. Add new Streaming content\n" +
                    "4. Remove streaming content\n" +
                    "5. Exit");

                string userInput = _console.ReadLine();

                switch (userInput)
                {
                    case "1":
                    case "one":
                    case "uno":
                        // Show all streaming content
                        ShowAllContent();
                        break;
                    case "2":
                        ShowContentByTitle();
                        // Find content by title
                        break;
                    case "3":
                        // Add new streaming content
                        CreateNewContent();
                        break;
                    case "4":
                        // Delete streaming content
                        RemoveContentFromList();
                        break;
                    case "5":
                    case "exit":
                        continueToRun = false;
                        break;
                    default:
                        _console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                            "Press any key to continue...");
                        _console.ReadKey();
                        break;
                }
            }
        }

        private void CreateNewContent()
        {
            _console.Clear();

            // Need a variable to capture information as we gather it.
            StreamingContent content = new StreamingContent();

            _console.WriteLine("Please enter a title: ");
            content.Title = _console.ReadLine();

            _console.WriteLine("Please enter a description: ");
            content.Description = _console.ReadLine();

            _console.WriteLine("Please enter a star rating: ");
            content.StarRating = double.Parse(_console.ReadLine());

            _console.WriteLine("Select a maturity rating: \n" +
                "01. G\n" +
                "02. PG\n" +
                "03. PG 13\n" +
                "04. R\n" +
                "05. NC-17\n" +
                "06. TV Y\n" +
                "07. TV G\n" +
                "08. TV PG\n" +
                "09. TV 14\n" +
                "10. TV MA\n");

            switch (_console.ReadLine())
            {
                // This is bad, and tedious
                case "1":
                    content.MaturityRating = MaturityRating.G;
                    break;
                case "2":
                    content.MaturityRating = MaturityRating.PG;
                    break;
                case "3":
                    content.MaturityRating = MaturityRating.PG_13;
                    break;
                case "4":
                    content.MaturityRating = MaturityRating.R;
                    break;
                case "5":
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
                case "6":
                    content.MaturityRating = MaturityRating.TV_Y;
                    break;
                case "7":
                    content.MaturityRating = MaturityRating.TV_G;
                    break;
                case "8":
                    content.MaturityRating = MaturityRating.TV_PG;
                    break;
                case "9":
                    content.MaturityRating = MaturityRating.TV_14;
                    break;
                case "10":
                    content.MaturityRating = MaturityRating.TV_MA;
                    break;
                default:
                    content.MaturityRating = MaturityRating.NC_17;
                    break;
            }
            // Bad way above, fancy way here.
            _console.WriteLine("Please select a genre:\n" +
                "1. Comedy\n" +
                "2. Action\n" +
                "3. Scifi\n" +
                "4. Fantasy\n" +
                "5. RomCom\n" +
                "6. Thriller\n" +
                "7. Drama\n" +
                "8. Adventure\n");

            // Comedy = 1 so we can take it in as an enum index through casting
            string genreInput = _console.ReadLine();

            int genreId = int.Parse(genreInput);

            content.TypeOfGenre = (GenreType)genreId;

            if (_streamingRepo.AddContentToDirectory(content))
            {
                _console.WriteLine("Content added!!");
                AnyKey();
            }
            else
            {
                _console.WriteLine("Content wasn't added!!");
                AnyKey();
            }

        }

        private void ShowAllContent()
        {
            _console.Clear();

            List<StreamingContent> listOfContent = _streamingRepo.GetContents();

            foreach (StreamingContent content in listOfContent)
            {
                DisplayContent(content);
            }
            AnyKey();
        }

        private void ShowContentByTitle()
        {
            _console.Clear();
            _console.Write("Enter a title: ");
            string title = _console.ReadLine();

            StreamingContent content = _streamingRepo.GetContentByTitle(title);

            if (content != null)
            {
                DisplayContent(content);
            }
            else
                _console.WriteLine("Invalid title, content not found.");

            AnyKey();
        }

        private void RemoveContentFromList()
        {
            _console.Clear();

            _console.WriteLine("Which item would you like to remove?\n");

            List<StreamingContent> currentContent = _streamingRepo.GetContents();

            int count = 0;
            foreach (StreamingContent content in currentContent)
            {
                // Increment counter to display
                count++;
                _console.WriteLine($"{count}. {content.Title}");
            }
            // Ask for number, take one off so it matches it's index (index's start at zero)
            int targetContentId = int.Parse(_console.ReadLine());
            int targetIndex = targetContentId - 1;

            if (targetIndex >= 0 && targetIndex < currentContent.Count)
            {
                // Get that content from that index location.
                StreamingContent desiredContent = currentContent[targetIndex];

                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    _console.WriteLine($"{desiredContent.Title} was deleted");
                    AnyKey();
                }
                else
                {
                    _console.WriteLine("Deletion failed");
                    AnyKey();
                }
            }
            else
                _console.WriteLine("No content with that ID");
        }

        private void DisplayContent(StreamingContent content)
        { // Helper method
            _console.WriteLine($"Title: {content.Title}\n" +
                $"Description: {content.Description}\n" +
                $"Genre: {content.TypeOfGenre}\n" +
                $"Star Rating: {content.StarRating}\n" +
                $"Maturity Rating: {content.MaturityRating}\n" +
                $"Is Family Friendly: {content.IsFamilyFriendly}\n");
        }

        private void AnyKey()
        {
            _console.WriteLine("Press any key to continue....");
            _console.ReadKey();
        }


        private void SeedContent()
        {
            StreamingContent toyStory = new StreamingContent("Toy Story", "Buzz Lightyear's origins", MaturityRating.G, 9, GenreType.Adventure);
            StreamingContent dune = new StreamingContent("Dune", "The story of house Atriedes", MaturityRating.R, 8, GenreType.SciFi);
            StreamingContent ghostBusters = new StreamingContent("Ghost Busters", "Bustin' makes me feel good", MaturityRating.PG_13, 8.5, GenreType.Comedy);

            _streamingRepo.AddContentToDirectory(toyStory);
            _streamingRepo.AddContentToDirectory(dune);
            _streamingRepo.AddContentToDirectory(ghostBusters);
        }

    }
}
