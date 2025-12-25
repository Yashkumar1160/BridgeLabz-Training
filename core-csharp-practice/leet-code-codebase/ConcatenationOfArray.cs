using System;
class ConcatenationOfArray{

	public static void Main(string[]args){
		Console.WriteLine("Enter size:");
		int n=Convert.ToInt32(Console.ReadLine());
		
		int[]nums=new int[n];
		
		Console.WriteLine("Enter elements");
		for(int i=0;i<n;i++){
			nums[i]=Convert.ToInt32(Console.ReadLine());
		}
		//create concatenated array of size 2n
		int[]result=new int[2*n];
		for(int i=0;i<n;i++){
			result[i]=nums[i];
			result[i+n]=nums[i];
		}
		Console.WriteLine("Concatenated Array:");
		for(int i=0;i<2*n;i++){
			Console.WriteLine(result[i]+" ");
		}
	}
}