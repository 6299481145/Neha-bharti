public class DuckSwim {
    public static void main(String[] args)throws Exception {
        Runtime runtime = Runtime.getRuntime();
        String[] s = new String[]{"C:\\Program Files\\VideoLAN\\VLC\\vlc.exe","D:\\Neha Bharti\\Java\\Duckswim.mp4"};
        Process process =runtime.exec(s);
    }
}