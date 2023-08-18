package org.example;

import java.nio.charset.StandardCharsets;
import java.security.MessageDigest;
import java.security.NoSuchAlgorithmException;

public class Main {
    public static void main(String[] args) {
        try {
            var password = "JuneDev";
            var digest = MessageDigest.getInstance("SHA-256");
            var sha256 = digest.digest(password.getBytes(StandardCharsets.UTF_8));
            System.out.println(byteToHex(sha256));
        } catch (NoSuchAlgorithmException e) {
            throw new RuntimeException(e);
        }
    }

    public static String byteToHex(byte[] bytes) {
        var result = new StringBuilder();
        for (var abyte : bytes) {
            result.append(String.format("%02x", abyte));
        }
        return result.toString();
    }
}