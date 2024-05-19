## Cara menggunakan aplikasi
1. Jalankan aplikasi Watermarking.exe (Jika muncul peringatan aplikasi berbahaya harap abaikan saja karena itu deteksi false positif, penyebabnya karena aplikasi tersebut tidak di rilis secara resmi)
2. Masuk ke menu "insert watermark" kemudian Load original image dan watermark yang ingin digunakan lalu tekan button "insert watermark", hasil watermarking akan muncul pada bagian watermarked image
3. Masuk ke menu "Extract Watermark" kemudian Load original image dan image yang telah di sisipkan watermark lalu tekan button "Extract watermark", hasil extract akan muncul pada bagian extracted watermark

## Cara membuka project
1. [Instal visual studio](https://visualstudio.microsoft.com/downloads/)
2. Instal net desktop development pada visual studio
3. Buka file Watermarking.sln yang terdapat pada folder Watermarking

## Note
1. Kualitas watermark tergantung pada media image yang digunakan, semakin tinggi pixel image yang digunakan maka kualitas watermark akan semakin bagus
2. Harap gunakan watermark dengan ukuran pixel yang sama dengan image yang ingin di sisipkan watermark supaya ukuran watermark tetap seperti aslinya
3. Secara default untuk insert watermark menggunakan nilai alpha 0.009 sedangkan untuk extract watermark menggunakan nilai alpha 0.010
4. Setiap image memiliki pengaturan nya masing masing (Nilai alpha pada saat insert dan extract watermark)
5. Media image dan watermark untuk testing telah di sediakan pada folder /Test Watermarking/Image
