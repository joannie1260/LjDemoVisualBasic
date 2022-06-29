
// GET RAW DATA PROPERTY JSON 
async function getPropertyInfos() {

    let id = document.getElementById("id").value
    console.log(id)
    let urlProprety = 'https://als.id-3.net/api2/property/getrawdata?id=' + id

    let response = await fetch(urlProprety)
    let data = await response.json()

    let linkPics = data.AllPhotos


    //    const merge1 = new Merge('')
    
    dataMerge.Region = data.Region
    dataMerge.Genre = data.Genre
    dataMerge.Bed = data.NbChambres
    dataMerge.Bath = data.NbSallesBains

    dataMerge.LinkPics1 = linkPics[0].PhotoUrl
    dataMerge.LinkPics2 = linkPics[1].PhotoUrl
    dataMerge.LinkPics3 = linkPics[2].PhotoUrl
    dataMerge.LinkPics4 = linkPics[3].PhotoUrl
    dataMerge.LinkPics5 = linkPics[4].PhotoUrl
    dataMerge.LinkPics6 = linkPics[5].PhotoUrl
    dataMerge.LinkPics7 = linkPics[6].PhotoUrl

    let jsonMerge = JSON.stringify(dataMerge)
    console.log(jsonMerge)


    let region = new Object()
    region.find = "Region"
    region.replace = data.Region


    let jsonMergeRegion = JSON.stringify(region)
    console.log(jsonMergeRegion)

    return data

}





