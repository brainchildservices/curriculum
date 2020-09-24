using System; 
  
class StringSplitter { 
  
      
    public string[] Split(string str) 
    { 
  
       
        //String str = "He is a very very good boy, isn't he?"; 
  
        String[] split = { " ", "'","?" ,","}; 
        
         
        String[] stringlist = str.Split(split,StringSplitOptions.RemoveEmptyEntries); 
        Console.WriteLine(stringlist.Length);
       return stringlist;
    } 
} 