package org.example;

import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;


public class Main {
    public static void main(String[] args) {
        try {
            String hash = "06797fa0f5489337f87b1cf39748c03a";
            String password = "JuneDev";

            var md = MessageDigest.getInstance("MD5");
            md.update(password.getBytes());
            var digest = md.digest();
            String newHash = encodeBitWise(digest);
            System.out.println(newHash);
        } catch (NoSuchAlgorithmException e) {
            throw new RuntimeException(e);
        }
    }

    public static String encodeBitWise(byte[] bytes) {
        var result = new StringBuilder();
        for (var abyte : bytes) {
            result.append(String.format("%02x", abyte));
        }
        return result.toString();
    }
}