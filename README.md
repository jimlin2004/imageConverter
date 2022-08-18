# 說明

這個圖片轉檔工具是基於.NET 6.07 core以及C++ OpenCV所建，<br>
所以需要.NET 6.07以上的Desktop Runtime 環境，<br>
由於WinForm目前僅支援Windows系統，因此Mac與Linux暫不支援。<br>
.NET Desktop Runtime載點<br>
https://dotnet.microsoft.com/en-us/download/dotnet/6.0<br>

## 可轉換的檔案:

|type|type|type|
|----|----|----|
|bmp |jpeg|sr  |
|dib |pfm |tif |
|hdr |pic |tiff|
|jpg |png |ras |
|jpe |pnm |webp|
|jp2 |ppm |

## 使用說明:

### 開啟程式

![image](https://github.com/jimlin2004/imageConverter/blob/main/img/tutorial_1.png)

### 選擇要轉換的格式

![image](https://github.com/jimlin2004/imageConverter/blob/main/img/tutorial_2.png)

選擇完檔案後，右上的圖片檢視可查看選擇的圖片，選擇欲轉換的檔名後即可按下[convert]鍵。

### 轉換成功

![image](https://github.com/jimlin2004/imageConverter/blob/main/img/tutorial_3.png)

轉換完成後，可於原檔案層級位置找到轉換後的圖片，訊息欄可檢視結果。

### 錯誤處理-圖片無法檢視

![image](https://github.com/jimlin2004/imageConverter/blob/main/img/tutorial_4.png)

有些圖片格式不支援檢視，下方訊息欄將告知該圖片無法檢視。

### 錯誤處理-圖片無法開啟(路徑錯誤或檔案不存在)

![image](https://github.com/jimlin2004/imageConverter/blob/main/img/tutorial_5.png)

轉換過程中如發生路徑錯誤或檔案不存在或檔案格式不支援等問題將於下方訊息欄告知錯誤，請前往檔案位置檢查檔案是否正常。
