public class Solution {
    public void Rotate(int[][] matrix) {
        
        int matrixSize = matrix.Length;
        
     // Transpoz
        for (int i = 0; i < matrixSize; i++)
        {
            for (int j = i + 1; j < matrixSize; j++)
            {
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }

        // Bütün satirlari 90 derece saat yonunde dondurmek icin transpozdan sonra satir siralamasini tersine ceviriyoruz.
        for (int i = 0; i < matrixSize; i++)
        {
            int left = 0;
            int right = matrixSize - 1;
            
            while (left < right)
            {
                int temp = matrix[i][left];
                matrix[i][left] = matrix[i][right];
                matrix[i][right] = temp;
                
                left++;
                right--;
            }
        }
    }
}