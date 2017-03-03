using Practice;
using Puzzles.BinaryTree;
using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        List<int> l1 = new List<int> { 3, 2, 1, 1, 1 };
        List<int> l2 = new List<int> { 4,3,2 };
        List<int> l3 = new List<int> { 2,5,4,1 };
        //Console.WriteLine(new MaxSumThreeStacks().maxSum(l1, l2, l3));

        List<int> l4 = new List<int> { 13,7,6,12};
        //Console.WriteLine(string.Join(",", new NextGreaterElement().getNGE(l4)));

        List<int> l5 = new List<int> { 12,11,10,5,6,2,30};
        //new SortedTriplet().PrintSortedTriplet(l5);

        List<int> l6 = new List<int> { 0, 0, 0 };
        //Console.WriteLine(new DistinctAbsoluteValues().distinctValues(l6));

        List<int> l7 = new List<int> {10,15,25 };
        List<int> l8 = new List<int> { 1,5,20,30};
        //new AlternateElements().printAlternate(l7,l8);

        List<int> l9 = new List<int> { 2,3,3,2,5};
        //new IntFrequency().printFrequency(l9);

        List<int> l10 = new List<int> { 1, 1, 1, 1, 0 };
        //Console.WriteLine(new ContiguousOnes().getIndex(l10));

        List<int> l11 = new List<int> { 1, 5, 10, 20, 40, 80 };
        List<int> l12 = new List<int> { 6, 7, 20, 80, 100 };
        List<int> l13 = new List<int> { 3, 4, 15, 20, 30, 70, 80, 120 };
        //new CommonElementsInSortedArrays().printCommonElements(l11, l12, l13);

        List<int> l14 = new List<int> { -1, 2, -3, 4, 5, 6, -7, 8, 9};
        //new AlternatePositiveNegative().print(l14);

        List<int> l15 = new List<int> { 10, 2, 3, 4, 5, 9, 7, 8 };
        //new CombinationOf4Sum().print(l15, 23);

        List<int> l16 = new List<int> { 1, 1, 0, -1, -2 };
        //new LowestMissingPositive().print(l16);

        List<int> l17 = new List<int> { 7, 6, 5, 5, 3, 4 };
        //Console.WriteLine(new Consecutive().areConsecutive(l17));

        //new ReverseList().getReversedList(GetList()).print();

        //new DeleteMiddle().deleteMiddle(GetList()).print();

        Node root = GetList();
        //new LoopDetectorAndRemover().removeLoop(root);
        //root.print();

        char[,] mat1 = { { 'a', 'a', 'a', 'b' }, { 'b', 'a', 'a', 'a' }, { 'a', 'b', 'b', 'a' } };
        //Console.WriteLine(new PalindromicMatrixPaths().countPaths(mat1));

        int[,] mat2 = {{ 4, 2 ,3 ,4 ,1 },
                     { 2 , 9 ,1 ,10 ,5 },
                     {15, 1 ,3 , 0 ,20 },
                     {16 ,92, 41, 44 ,1},
                     {8, 142, 6, 4, 8} };

        //Console.WriteLine(new MaxWeightMatrixPath().getMax(mat2));

        int[,] mat3 = { { -3, -2, -1, 1 }, { -2, 2, 3, 4 }, { 4, 5, 7, 8 } };
        //Console.WriteLine(new CountNegativesInSortedMatrix().count(mat3));

        char[,] mat4={{'X', 'O', 'O', 'O', 'O', 'O'},
              {'X', 'O', 'X', 'X', 'X', 'X'},
              {'O', 'O', 'O', 'O', 'O', 'O'},
              {'X', 'X', 'X', 'O', 'X', 'X'},
              {'X', 'X', 'X', 'O', 'X', 'X'},
              {'O', 'O', 'O', 'O', 'X', 'X'},
             }; ;

        //Console.WriteLine(new CountIslands().count(mat4));

        //Console.WriteLine(new CountPalindromes().count("abbaeae"));

        //Console.WriteLine(new ApproximateAnagrams().countMinCharsToRemove("bca", "acb"));

        //Console.WriteLine(new IntegerTransform().countOperations(2,5));

        //Console.WriteLine(new ReachEndOfArray().countSteps(new List<int> { 5, 4, 2, 5, 0 }));

        char[,] input = {{'O',  'O',  'O',  'O',  'G'},
                          {'O',  'W',  'W',  'O',  'O'},
                          {'O',  'O',  'O',  'W',  'O'},
                          {'G',  'W',  'W',  'W',  'O'},
                          {'O',  'O',  'O',  'O',  'G'}};

        //new MatrixPrison().printOutput(input);

        int?[,] adj= { { null, 10, 3, 2 }, { null, null, null, 7 }, { null, null, null, 6 }, { null, null, null, null } };
        //Console.WriteLine(new kLengthShortestPath().getKLengthShortestPath(adj,0,3,2));

        //var heap = new ConvertBSTToHeap().heapify(GetBinaryNode());

        //Console.WriteLine(new ExponentOf2().isExponentOf2(128));

        //BinaryNode bst = new PreorderOfBSTToBST().toBST(new List<int> { 10, 5, 1, 7, 40, 50 });

        //BinaryNode bst = new SortedArrayToBalancedBST().toBalancedBST(new List<int> { 1, 2, 3, 4, 5 });

        Console.WriteLine(new LargestBST().largestBSTSize(GetBinaryNode1()));

        Console.ReadKey();
    }

    private static Node GetList()
    {
        Node n1 = new Node { data = 1 };
        Node n2 = new Node { data = 2 };
        Node n3 = new Node { data = 3 };
        Node n4 = new Node { data = 4 };
        Node n5 = new Node { data = 5 };
        n1.Next = n2;n2.Next = n3;n3.Next = n4;n4.Next = n5;n5.Next = n2;

        return n1;
    }

    private static BinaryNode GetBinaryNode()
    {
        var n8 = new BinaryNode(8, null, null);
        var n4 = new BinaryNode(4, null, null);
        var n12 = new BinaryNode(12, null, null);
        var n2 = new BinaryNode(2, null, null);
        var n6 = new BinaryNode(6, null, null);
        var n10 = new BinaryNode(10, null, null);
        var n14= new BinaryNode(14, null, null);

        n8.left = n4;n8.right = n12;
        n4.left = n2;n4.right = n6;
        n12.left = n10;n12.right = n14;

        return n8;
    }

    private static BinaryNode GetBinaryNode1()
    {
        var n5 = new BinaryNode(8, null, null);
        var n2 = new BinaryNode(4, null, null);
        var n4 = new BinaryNode(12, null, null);
        var n1 = new BinaryNode(2, null, null);
        var n3 = new BinaryNode(6, null, null);

        n5.right = n4;
        n5.left = n2;
        n2.left = n1;
        n2.right = n3;

        return n5;
    }
}