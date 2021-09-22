/*
Given an n x n binary matrix image, flip the image horizontally, then invert it, and return the resulting image.

To flip an image horizontally means that each row of the image is reversed.

For example, flipping [1,1,0] horizontally results in [0,1,1].
To invert an image means that each 0 is replaced by 1, and each 1 is replaced by 0.

For example, inverting [0,1,1] results in [1,0,0].

*/

public class Solution {
    public int[][] FlipAndInvertImage(int[][] image) {
        int[][] invertedImg = new int[image.Length][];
        
        for(int i=0;i<image.Length;i++){
            invertedImg[i] = new int[image[i].Length];
            for(int j=image[i].Length-1;j>=0;j--){
                
                if(image[i][j]==0){
                    invertedImg[i][(image[i].Length-1)-j] = 1;
                }
                else{
                     invertedImg[i][(image[i].Length-1)-j] = 0;
                }
                
            }
        }
        
        
        return invertedImg;
    }
}