using System;
public class HuffmanNode{
    public char? Character;
    public int Frequency;
    public HuffmanNode? Left,Right;
    public bool IsLeaf=>Left==null && Right==null;
}
public class Huffman{
    public static void Main(){
        string inputText="Ryan é burro";
        int[] charFrequencies=new int[256];
        for(int i=0;i<inputText.Length;i++) charFrequencies[(int)inputText[i]]++;
        HuffmanNode[] nodes=new HuffmanNode[256]; int nodeCount=0;
        for(int i=0;i<256;i++){
            if(charFrequencies[i]>0){
                nodes[nodeCount]=new HuffmanNode{Character=(char)i,Frequency=charFrequencies[i]};
                nodeCount++;
            }
        }
        while(nodeCount>1){
            int min1=FindMinIndex(nodes,nodeCount);
            HuffmanNode left=nodes[min1]; RemoveAt(ref nodes,ref nodeCount,min1);
            int min2=FindMinIndex(nodes,nodeCount);
            HuffmanNode right=nodes[min2]; RemoveAt(ref nodes,ref nodeCount,min2);
            nodes[nodeCount++]=new HuffmanNode{Character=null,Frequency=left.Frequency+right.Frequency,Left=left,Right=right};
        }
        HuffmanNode tree=nodes[0]; string[] huffmanCodes=new string[256];
        if(tree.IsLeaf && tree.Character.HasValue) huffmanCodes[(int)tree.Character.Value]="0";
        else GenerateCodes(tree,"",huffmanCodes);
        Console.WriteLine("Char|Code");
        for(int i=0;i<256;i++){
            if(huffmanCodes[i]!=null) Console.WriteLine("{0}:{1}",(char)i,huffmanCodes[i]);
        }
        string encoded=""; 
        for(int i=0;i<inputText.Length;i++) encoded+=huffmanCodes[(int)inputText[i]];
        Console.WriteLine("Encoded:"); 
        Console.WriteLine(encoded);
        Console.ReadKey();
    }
    static int FindMinIndex(HuffmanNode[] nodes,int count){
        int min=0;
        for(int i=1;i<count;i++){
            if(nodes[i].Frequency<nodes[min].Frequency) min=i;
        }
        return min;
    }
    static void RemoveAt(ref HuffmanNode[] nodes,ref int count,int index){
        for(int i=index;i<count-1;i++) nodes[i]=nodes[i+1];
        count--;
    }
    static void GenerateCodes(HuffmanNode node,string code,string[] codes){
        if(node==null)return;
        if(node.IsLeaf && node.Character.HasValue){codes[(int)node.Character.Value]=code;return;}
        GenerateCodes(node.Left,code+"0",codes);
        GenerateCodes(node.Right,code+"1",codes);
    }
}
