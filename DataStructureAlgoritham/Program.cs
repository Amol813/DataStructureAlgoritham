using System;
using System.IO;
namespace DataStructureAlgorithm
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Algorithm Problem!");

            BinarySearch binarySearch = new BinarySearch();
            binarySearch.ReadFile("E:\\pl_.net_exercise\\DataStructureAlgoritham\\DataStructureAlgoritham\\File1.txt");

        }
    }
}