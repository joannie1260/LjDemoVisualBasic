// At click Loading
 function loading(){
    document.getElementById('box').style.display = "block"
 }

 function videoShow() {
    document.getElementById('video').style.display ="block"
 }

// GET RAW DATA PROPERTY JSON 
    async function getApiProperty(){
        
        let id = document.getElementById("id").value
        const urlProprety = '' + id
        
        let response = await fetch(urlProprety)
        let data = await response.json()

        let linkPics = data.AllPhotos
        
        // linkPics.forEach(links => {
            //   console.log(links.PhotoUrl)
            //  })
            
            // test de creation valeurs
          
            
            let jsonMerge = JSON.stringify(dataMerge)
            console.log(jsonMerge)
            
           let merge = new MergeInfos(data.Region, data.Genre, data.NbChambres  )
            console.log(merge)


             merge.find = "Region"
             merge.replace = data.Region
             
            return jsonMerge

    }

// POST RAW - API SHOTSTACK
    async function postShotstackId(){
        
        myHeaders = new Headers
        myHeaders.append("Access-Control-Allow-Origin", "origin")
        myHeaders.append("cache-control", "no-cache")
        myHeaders.append("Accept", "application/json")
        myHeaders.append("x-api-key", "qDiyycLgsc8xI1kdKIGn84D4x4hyOIhk15qFtljm")

        const urlShotstack = 'https://api.shotstack.io/stage/render' 

    // Merge des fichiers merge et raw
        let raw = JSON.stringify({
            "timeline": {
              "tracks": [
                {
                  "clips": [
                    {
                      "asset": {
                        "type": "html",
                        "html": "<p>{{Genre}}</p>",
                        "css": "p { font-family: \"Manrope ExtraBold\"; color: #fff; font-size: 45px; text-align: left;    line-height: 78; }",
                        "width": 800,
                        "height": 200,
                        "position": "top"
                      },
                      "start": 1,
                      "length": 5,
                      "position": "left",
                      "offset": {
                        "x": 0.1,
                        "y": -0.3
                      },
                      "transition": {
                        "in": "slideRight",
                        "out": "slideLeft"
                      }
                    },
                    {
                      "asset": {
                        "type": "html",
                        "html": "<p>Saint-Colomban, QC </p>",
                        "css": "p { font-family: \"Manrope ExtraBold\"; color: #fff; font-size: 22px; text-align: left;    line-height: 78; }",
                        "width": 800,
                        "height": 100,
                        "position": "top"
                      },
                      "start": 1,
                      "length": 5,
                      "position": "left",
                      "offset": {
                        "x": 0.1,
                        "y": -0.2
                      },
                      "transition": {
                        "in": "slideRight",
                        "out": "slideLeft"
                      }
                    }
                  ]
                },
                {
                  "clips": [
                    {
                      "asset": {
                        "type": "image",
                        "src": "https://templates.shotstack.io/basic/asset/image/icon/slimline/white/26px/bed.png"
                      },
                      "start": 1,
                      "length": 5,
                      "fit": "none",
                      "position": "left",
                      "offset": {
                        "x": 0.1,
                        "y": -0.35
                      },
                      "transition": {
                        "in": "fade",
                        "out": "fade"
                      }
                    },
                    {
                      "asset": {
                        "type": "image",
                        "src": "https://templates.shotstack.io/basic/asset/image/icon/slimline/white/26px/bath.png"
                      },
                      "start": 1,
                      "length": 5,
                      "fit": "none",
                      "position": "left",
                      "offset": {
                        "x": 0.2,
                        "y": -0.35
                      },
                      "transition": {
                        "in": "fade",
                        "out": "fade"
                      }
                    },
                    {
                      "asset": {
                        "type": "html",
                        "html": "<p>4</p>",
                        "css": "p { font-family: \"Manrope ExtraBold\"; color: #ffffff; font-size: 18px; text-align: left;     }",
                        "width": 36,
                        "height": 26,
                        "position": "center"
                      },
                      "start": 1,
                      "length": 5,
                      "position": "left",
                      "offset": {
                        "x": 0.15,
                        "y": -0.35
                      },
                      "transition": {
                        "in": "fade",
                        "out": "fade"
                      }
                    },
                    {
                      "asset": {
                        "type": "html",
                        "html": "<p>2</p>",
                        "css": "p { font-family: \"Manrope ExtraBold\"; color: #ffffff; font-size: 18px; text-align: left;     }",
                        "width": 36,
                        "height": 26,
                        "position": "center"
                      },
                      "start": 1,
                      "length": 5,
                      "position": "left",
                      "offset": {
                        "x": 0.165,
                        "y": -0.35
                      },
                      "transition": {
                        "in": "fade",
                        "out": "fade"
                      }
                    }
                  ]
                },
                {
                  "clips": [
                    {
                      "asset": {
                        "type": "image",
                        "src": "https://imagizer.imageshack.com/img924/2742/3417WT.png"
                      },
                      "start": 30,
                      "length": 6,
                      "fit": "none",
                      "scale": 0.4,
                      "offset": {
                        "x": 0,
                        "y": 0.22
                      },
                      "transition": {
                        "in": "fade"
                      }
                    }
                  ]
                },
                {
                  "clips": [
                    {
                      "asset": {
                        "type": "html",
                        "html": "<p>Francis Penna</p>",
                        "css": "p { font-family: \"Manrope ExtraBold\"; color: #f0c20c; font-size: 26px; text-align: center;     }",
                        "width": 600,
                        "height": 36,
                        "position": "center"
                      },
                      "start": 30,
                      "length": 6,
                      "offset": {
                        "x": 0,
                        "y": 0.045
                      },
                      "transition": {
                        "in": "fade"
                      }
                    },
                    {
                      "asset": {
                        "type": "html",
                        "html": "<p> 450-438-6868</p>",
                        "css": "p { font-family: \"Manrope Light\"; color: #ffffff; font-size: 18px; text-align: center;     }",
                        "width": 600,
                        "height": 64,
                        "position": "center"
                      },
                      "start": 30,
                      "length": 6,
                      "offset": {
                        "x": 0,
                        "y": -0.24
                      },
                      "transition": {
                        "in": "fade"
                      }
                    }
                  ]
                },
                {
                  "clips": [
                    {
                      "asset": {
                        "type": "image",
                        "src": "https://imagizer.imageshack.com/img924/9283/1bLNzl.jpg"
                      },
                      "start": 30,
                      "length": 6,
                      "fit": "contain",
                      "scale": 0.2,
                      "offset": {
                        "x": 0,
                        "y": -0.08
                      },
                      "transition": {
                        "in": "fade"
                      }
                    }
                  ]
                },
                {
                  "clips": [
                    {
                      "asset": {
                        "type": "image",
                        "src": "https://imagizer.imageshack.com/img924/9283/1bLNzl.jpg"
                      },
                      "start": 0,
                      "length": 3.5
                    }
                  ]
                },
                {
                  "clips": [
                    {
                      "asset": {
                        "type": "image",
                        "src": "https://images.viacapitale.info/images/inscriptions/10992086/1.jpg"
                      },
                      "start": 0,
                      "length": 4,
                      "effect": "zoomInSlow",
                      "transition": {
                        "in": "fade"
                      }
                    },
                    {
                      "asset": {
                        "type": "image",
                        "src": "https://images.viacapitale.info/images/inscriptions/10992086/3.jpg"
                      },
                      "start": 4,
                      "length": 4,
                      "effect": "slideLeftSlow",
                      "transition": {
                        "in": "fade"
                      }
                    },
                    {
                      "asset": {
                        "type": "image",
                        "src": "https://images.viacapitale.info/images/inscriptions/10992086/4.jpg"
                      },
                      "start": 12,
                      "length": 6,
                      "effect": "slideRightSlow"
                    },
                    {
                      "asset": {
                        "type": "image",
                        "src": "https://images.viacapitale.info/images/inscriptions/10992086/5.jpg"
                      },
                      "start": 17,
                      "length": 4,
                      "effect": "slideUpSlow"
                    },
                    {
                      "asset": {
                        "type": "image",
                        "src": "https://images.viacapitale.info/images/inscriptions/10992086/6.jpg"
                      },
                      "start": 21,
                      "length": 4,
                      "effect": "slideLeftSlow"
                    },
                    {
                      "asset": {
                        "type": "image",
                        "src": "https://imagizer.imageshack.com/img924/9283/1bLNzl.jpg"
                      },
                      "start": 30,
                      "length": 6,
                      "effect": "zoomInSlow"
                    }
                  ]
                }
              ],
              "fonts": [
                {
                  "src": "https://templates.shotstack.io/basic/asset/font/manrope-extrabold.ttf"
                },
                {
                  "src": "https://templates.shotstack.io/basic/asset/font/manrope-light.ttf"
                }
              ],
              "soundtrack": {
                "src": "https://shotstack-assets.s3.ap-southeast-2.amazonaws.com/music/unminus/ambisax.mp3",
                "effect": "fadeOut"
              }
            },
            "output": {
              "format": "mp4",
              "resolution": "sd"
            }
          })
        

    //  POST - OPTIONS
        const options = {
            headers: myHeaders,
            method: 'POST',
            body: raw,
            redirect: 'follow'
        }
        
        // FETCH API SHOTSTACK
        let responseShotstackAPI = await fetch(urlShotstack, options)
        let dataShotstack = await responseShotstackAPI.json()
        .then(dataShotstack => console.log(dataShotstack))

        // Conserve la valeur id de shotstack en memoire
        let idShotstack = dataShotstack.reponse.id
        return idShotstack

    }

// GET STATUS - API SHOTSTACK
    async function getStatus(){
       
        let id = '58f9af52-34c2-4657-b587-3301cda71aa0'
        const urlShotstack = 'https://api.shotstack.io/stage/render/' + id
        const options = {
            method: 'GET',
        }
    
        let responseShotstackStatus = await fetch(urlShotstack, options)
        let dataShotstack = await responseShotstackStatus.json()
        .then(dataShotstack => console.log(dataShotstack))

        let videoUrl = dataShotstack.reponse.url

        return videoUrl

    }

    function changeSource(url) {
        var video = document.getElementById('video');
        video.src = "https://shotstack-api-stage-output.s3-ap-southeast-2.amazonaws.com/ley261vcv5/58f9af52-34c2-4657-b587-3301cda71aa0.mp4"
        video.play();
     }



    
    
