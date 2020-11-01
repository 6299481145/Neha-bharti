import java.text.ParseException;
import java.util.concurrent.TimeUnit;
 
public class Main 
{
  public static void main(String[] args) throws ParseException 
  {
    Instant start = Instant.now();
 
    //Measure execution time for this method
    methodToTime();
 
    Instant finish = Instant.now();
 
    long timeElapsed = Duration.between(start, finish).toMillis();  //in millis
  }
 
  private static void methodToTime() {
    try {
      TimeUnit.SECONDS.sleep(3);
    } catch (InterruptedException e) {
      e.printStackTrace();
    }
  }
}