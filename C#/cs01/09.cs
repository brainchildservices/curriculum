using System; 
  
class SplittingString { 
  
      
    public string[] Splitter(string str) 
    { 
  
       
        //String str = "He is a very very good boy, isn't he?"; 
  
        String[] split = { " ", "'","?" ,","}; 
        
         
        String[] stringlist = str.Split(split,StringSplitOptions.RemoveEmptyEntries); 
        Console.WriteLine(stringlist.Length);
       return stringlist;
    } 
} 