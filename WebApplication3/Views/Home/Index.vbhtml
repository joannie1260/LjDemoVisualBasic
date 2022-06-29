﻿<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="~/Views/Home/Style.scss">
    <title>Démo Video</title>
</head>
<body class="align">
    <div class="grid">
        <!-- FORM GET ID Property -->
        <h1>Créer une vidéo</h1>
        <form name="getId" action="#" method="GET" class="form id">
            <div class="form__field">
                <label for="id">
                    <svg xmlns="http://www.w3.org/2000/svg" class="icon">
                        <path d="M8.354 1.146a.5.5 0 0 0-.708 0l-6 6A.5.5 0 0 0 1.5 7.5v7a.5.5 0 0 0 .5.5h4.5a.5.5 0 0 0 .5-.5v-4h2v4a.5.5 0 0 0 .5.5H14a.5.5 0 0 0 .5-.5v-7a.5.5 0 0 0-.146-.354L13 5.793V2.5a.5.5 0 0 0-.5-.5h-1a.5.5 0 0 0-.5.5v1.293L8.354 1.146zM2.5 14V7.707l5.5-5.5 5.5 5.5V14H10v-4a.5.5 0 0 0-.5-.5h-3a.5.5 0 0 0-.5.5v4H2.5z" />
                    </svg>
                    <span class="hidden"></span>
                </label>
                <input id="id" type="text" name="id" class="form__input" placeholder="ID de la propriété" required>
            </div>
            <button value="show" class="button" onclick="getPropertyInfos();loading();videoShow()"> Générer le vidéo </button>
        </form>

        <!-- If User don't have ID -->
        <p class="text--center">
            Je n'ai pas le ID?
            <a href="#">Je veux l'obtenir</a>
        </p>
        <div id="box" style="display:none;">
            <!-- LOANDING SECTION -> when SUBMIT -->
            <div id="loading" name="loading">
                <h1>Merci de ta patience ...  </h1>
                <p>La vidéo sera bientôt disponible</p>
                <div class="loader">
                    <div class="circle"></div>
                    <div class="circle"></div>
                    <div class="circle"></div>
                </div>
            </div>
        </div>
    </div>
    <!-- VIDEO VIEW  -->
    <video id="video" width="320" height="240" style="display:none;"></video>

    <script src="~/Views/Home/propertyInfos.js"></script>
    <script src="~/Views/Home/ShotstackInfos.js"></script>
    <script src="~/Views/Home/main.js"></script>
    <script src="~/Views/Home/main.js"></script>
</body>
</html>