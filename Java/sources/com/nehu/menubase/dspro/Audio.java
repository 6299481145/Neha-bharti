package com.nehu.menubase.dspro;

import java.io.File;
import java.io.IOException;
//import java.util.Scanner;
import javax.sound.sampled.*;

public class Audio {

  //   public static void main(String[] args) {
  //     Audio ad = new Audio();
  //     ad.mainmenu_audio();
  //     ad.submenu_audio();
  //   }

  Clip clip = null;

  public void mainmenu_audio() {
    //Scanner scanner = new Scanner(System.in);

    File file = new File(
      "D:\\Neha Bharti\\Java\\sources\\com\\nehu\\menubase\\dspro\\mainmenu_audio.wav"
    );
    AudioInputStream audiostream = null;
    try {
      audiostream = AudioSystem.getAudioInputStream(file);
    } catch (UnsupportedAudioFileException e) {
      e.printStackTrace();
    } catch (IOException e) {
      e.printStackTrace();
    }
    try {
      clip = AudioSystem.getClip();
    } catch (LineUnavailableException e) {
      e.printStackTrace();
    }
    try {
      clip.open(audiostream);
    } catch (LineUnavailableException e) {
      e.printStackTrace();
    } catch (IOException e) {
      e.printStackTrace();
    }
    clip.start();
    //   clip.stop();

    // String response = scanner.next();
    // scanner.close();
  }

  public void submenu_audio() {
    //Scanner sc = new Scanner(System.in);
    File file = new File(
      "D:\\Neha Bharti\\Java\\sources\\com\\nehu\\menubase\\dspro\\submenu_audio.wav"
    );
    AudioInputStream audiostream = null;
    try {
      audiostream = AudioSystem.getAudioInputStream(file);
    } catch (UnsupportedAudioFileException e) {
      e.printStackTrace();
    } catch (IOException e) {
      e.printStackTrace();
    }
    try {
      clip = AudioSystem.getClip();
    } catch (LineUnavailableException e) {
      e.printStackTrace();
    }
    try {
      clip.open(audiostream);
    } catch (LineUnavailableException e) {
      e.printStackTrace();
    } catch (IOException e) {
      e.printStackTrace();
    }
    clip.start();
    //   clip.stop();
    //String response = sc.next();
    // sc.close();
  }

  public void stop() {
    clip.stop();
    clip.close();
  }
}
