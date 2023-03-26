public class ChineseMedicineIllustratedData {

    public ChineseMedicineIllustratedData() {
        this.name = "";
        this.description = "";
        this.sprite = "";
    }

    public ChineseMedicineIllustratedData(string name, string description, string sprite) {
        this.name = name;
        this.description = description;
        this.sprite = sprite;
    }

    private string name;
    private string description;
    private string sprite;
    // private int id;
    // private string season;

    public string Name {
        get { return name; }
        set { name = value; }
    }

    public string Description {
        get { return description; }
        set { description = value; }
    }

    public string Sprite {
        get { return sprite; }
        set { sprite = value; }
    }

}
