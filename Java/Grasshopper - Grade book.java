// https://www.codewars.com/kata/55cbd4ba903825f7970000f5/train/java

public class GrassHopper {

    public static char getGrade(int s1, int s2, int s3) {
      int average = (s1 + s2 + s3)/3;
      if( 90<= average && average <= 100){
        return 'A';
      }
      else if ( 80 <= average && average < 90){
        return 'B';
      }
      else if (70 <= average && average < 80){
        return 'C';
      }
      else if (60 <= average && average < 70){
        return 'D';
      }
      else if (0 <= average && average < 60){
        return 'F';
      }
      else {
        return 0;
      }
    }
}
