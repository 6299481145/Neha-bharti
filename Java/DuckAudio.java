import java.io.File;
import java.io.IOException;
import java.util.Scanner;
import javax.sound.sampled.*;

public class DuckAudio {
    public static void main(String[] args) throws UnsupportedAudioFileException, IOException, LineUnavailableException {

       Scanner sc = new Scanner(System.in);

        File file = new File("DuckAudio.wav");
        AudioInputStream audiostream = AudioSystem.getAudioInputStream(file);
        Clip clip = AudioSystem.getClip();
        clip.open(audiostream);
        clip.start();

       String response = sc.next();

        sc.close();
    }
}