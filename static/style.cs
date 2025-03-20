<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Styled CAPTCHA Generator</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            background-color: #f4f4f4;
        }
        .captcha-container {
            background: #fff;
            padding: 20px;
            border-radius: 10px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            text-align: center;
        }
        .captcha-box {
            font-size: 24px;
            font-weight: bold;
            letter-spacing: 3px;
            text-decoration: line-through;
            display: inline-block;
            padding: 10px;
            background: #ddd;
            border-radius: 5px;
            margin-bottom: 10px;
            user-select: none;
        }
        .captcha-input {
            padding: 8px;
            font-size: 16px;
            width: 80%;
            margin-bottom: 10px;
        }
        .captcha-buttons button {
            padding: 10px;
            margin: 5px;
            border: none;
            background: #007bff;
            color: white;
            border-radius: 5px;
            cursor: pointer;
        }
        .captcha-buttons button:hover {
            background: #0056b3;
        }
    </style>
</head>
<body>
    <div class="captcha-container">
        <div id="captcha" class="captcha-box"></div>
        <input type="text" id="captchaInput" class="captcha-input" placeholder="Enter CAPTCHA">
        <div class="captcha-buttons">
            <button onclick="validateCaptcha()">Submit</button>
            <button onclick="generateCaptcha()">Refresh</button>
        </div>
        <p id="captchaMessage"></p>
    </div>
    
    <script>
        function generateCaptcha() {
            let chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            let captchaText = "";
            for (let i = 0; i < 6; i++) {
                captchaText += chars.charAt(Math.floor(Math.random() * chars.length));
            }
            document.getElementById("captcha").textContent = captchaText;
        }
        
        function validateCaptcha() {
            let userCaptcha = document.getElementById("captchaInput").value;
            let actualCaptcha = document.getElementById("captcha").textContent;
            let message = document.getElementById("captchaMessage");
            if (userCaptcha === actualCaptcha) {
                message.textContent = "CAPTCHA Matched!";
                message.style.color = "green";
            } else {
                message.textContent = "Incorrect CAPTCHA. Try Again.";
                message.style.color = "red";
            }
        }
        
        window.onload = generateCaptcha;
    </script>
</body>
</html>

