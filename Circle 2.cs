using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CSharp_Shell
{

    public class Random_Circle
    {
        public static void Main()
        {
        	Random random= new Random(); //for random numbers

          
                    int radius=3; //radius of circle
            		int number_of_circle=15;
            		int lowest_x=-150;
            		int highest_x=160;  /* range of x-axis and y axis in graph */
            		int lowest_y=-150; 
            		int highest_y=160;   
            		int minimum=2; //minimum space between circles
                    int count1=0; //how many numbers added to blocked_x array
                    int count2=0; //how many numbers added to blocked_y array
      
/* blocked_x and blocked_y array will  store the coordinates of the places that are alraedy filled with a circle */
         	int []blocked_x=new int[highest_x-lowest_x];
        	int []blocked_y=new int[highest_y-highest_y];
          
       
       
       
          int i;
         for(i=0;i<number_of_circle;i++)
              {
                  
               //cx and cy refer the coordinate of the the random circle	   
       
 
            	   int cx,cy,j,k,condition=0;
                  	A:
            		cx= random.Next((lowest_x/4),(highest_x/4));
            		     for(j=0;j<blocked_x.Length;j++)
            		      {
            		      	if(cx==blocked_x[j])
            		           condition++;
            		      }
            	    
            		cy= random.Next((lowest_y/4),(highest_y/4));
            		     for(k=0;k<blocked_x.Length;k++)
            		      {
            		      	if(cx==blocked_x[k])
            		           condition++;
            		      }
 /*  We've randomly assigned coordinates to cx and cy and checked if the random numbers are not matching with any of  the
  blocked array. If they are not in the blocked array we"ll print them. Otherwise we"ll again assign random numbers using goto statement
 */        
               if(condition>=2)
                goto A;
            
            	Console.WriteLine(cx+","+cy); //printing the verified coordinates of the circle
            	condition=0;
     
   /*Now we"ll add the coordinates of the places surrounded by this circle to the blocked array so that the 2nd circle don't appear in this 1st circle*/
     
            	 int f;
            	 for(f=cx-(radius+minimum);f<=cx+(radius+minimum);f++)
            	     {
            	     	blocked_x[count1]=f;
            	        count1++;
            	     	
            	     }
            	 
            	int g;
            	 for(g=cy-(radius+minimum);g<=cy+(radius+minimum);g++)
            	     {
            	     	blocked_x[count2]=f;
            	        count2++;
          // We have kept this process in a loop. So we can get as many random circles as we want that won't collide with each other  	     	
            	     }
          	    
            	   
             }
        }
    }
}