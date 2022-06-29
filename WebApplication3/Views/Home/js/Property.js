class PropertyInfos {

    constructor(Id, Genre, Bed, Bath, LinkPics1, LinkPics2, LinkPics3, LinkPics4, LinkPics5, LinkPics6) {

        this.Id = Id
        this.Genre = Genre
        this.Bed = Bed
        this.Bath = Bath
        this.LinkPics1 = LinkPics1
        this.LinkPics2 = LinkPics2
        this.LinkPics3 = LinkPics3
        this.LinkPics4 = LinkPics4
        this.LinkPics5 = LinkPics5
        this.LinkPics6 = LinkPics6
    
        }
        
        getInfos() {
            return this.Id, 
            this.Genre, 
            this.Bed, 
            this.Bath, 
            this.LinkPics1, 
            this.LinkPics2, 
            this.LinkPics3,
            this.LinkPics4,
            this.LinkPics5,
            this.LinkPics6
        }
}

const newInfos = new PropertyInfos ("1220055", "bla", "bla", "bla", "bla", "bla", "bla", "bla", "bla","bla")

console.dir(newInfos)
console.dir(PropertyInfos)

