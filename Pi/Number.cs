namespace PI {
    public class Number {
        public double X { get; set; }
        public double Y { get; set; }
        public double R {  get; set; }
        public bool InCircle { get; set; }

        public override string ToString() {
            return String.Format("X: {0}, Y: {1}, R: {2}, InCircle: {3}", X, Y, R, InCircle);
        }
    }
}