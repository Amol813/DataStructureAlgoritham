
using DataSrtuctureAlgoritham;
using DataStructureAlgorithm;
using System;
using System.IO;
namespace DataStructureAlgoritham
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Algorithm Problem!");

            BinarySearch binarySearch = new BinarySearch();
            binarySearch.ReadFile("E:\\pl_.net_exercise\\DataStructureAlgoritham\\DataStructureAlgoritham\\File1.txt");

            InsertionSort sort = new InsertionSort();
            sort.ReadFile("E:\\pl_.net_exercise\\DataStructureAlgoritham\\DataStructureAlgoritham\\File1.txt");

            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.ReadFile("E:\\pl_.net_exercise\\DataStructureAlgoritham\\DataStructureAlgoritham\\Filename.txt");

            Anagram anagram = new Anagram();
            anagram.CheckAnagram();

            CustomizeString customize = new CustomizeString();
            customize.customize();
        }

    }
}