using System;
using System.Collections.Generic;
namespace MVCBasicsAssignment.Models
{
    public class GitHubProjects
    {
        static List<Project> GitProjects = new List<Project>()
        {
            new Project() {Name = "Hangman", Description = "Simple console application in C# reproducing the alphabet guessing game with life and death in stake.", WebAdress = "https://github.com/Exilic/Hangman"},
            new Project() {Name = "Calculator RPN", Description = "The calculator mimics some of the functionality of an old Hewlett-Packard calculator. It uses reverse Polish notation, where the operands preceed the operator.", WebAdress = "https://github.com/Exilic/CalculatorRPN"},
            new Project() {Name = "Vending Machine", Description = "An exercise in classes and objects, on the premise of representing a vending machine (the ones found in hospitals or schools) as digital object. The internal order is very mechanical, by design.", WebAdress = "https://github.com/Exilic/VendingMachine"}
        };

        public void Add(string name, string description, string webAdress)
        {
            GitProjects.Add(new Project() { Name = name, Description = description, WebAdress = webAdress });
        }

        public List<Project> All()
        {
            return GitProjects;
        }
    }
}
