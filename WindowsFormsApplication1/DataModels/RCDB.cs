using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataModels
{
    public static class RCDB
    {
        public static List<Perm> PLL = new List<Perm>();

        //where we add perms.
        static RCDB()
        {
            Perm p;

            p = NewPerm("H", "H.png", "This is the H Perm it's pretty easy.");
            p.Algorithms.Add(NewAlg("M2 U M2 U2 M2 U M2", "Two-Handed", "Use Middle Finger and Ring Finger for M Slices", true));
            p.Algorithms.Add(NewAlg("M2 U' M2 U2 M2 U' M2", "Two-Handed", "Two-Handed: Same as above just for people who think U' moves are easier.", true));
            p.Algorithms.Add(NewAlg("R2 U2 R U2 R2 U2 R2 U2 R U2 R2", "One-Handed - Left Hand", "One-Handed - Left Hand: Double Flick R2's with your pinkie and your ring finger.", true));
            PLL.Add(p);

            p = NewPerm("Z", "Z.png", "This is the Z perm easy to recognize.");
            p.Algorithms.Add(NewAlg("M2' U M2' U M' U2 M2' U2 M' U2", "Two-Handed", "Use Middle Finger and Ring Finger for M Slices", false));
            p.Algorithms.Add(NewAlg("y M2' U' M2' U' M' U2 M2' U2 M' U2", "Two-Handed", "Use Middle Finger and Ring Finger for M Slices", false));
            p.Algorithms.Add(NewAlg("R' U' R2 U R U R' U' R U R U' R U' R'", "One-Handed - Left Hand", "One-Handed - Left Hand: Double Flick R2 with your pinkie and your ring finger.", false));
            PLL.Add(p);

            p = NewPerm("Y", "Y.png", "look for the cube surrounded by two 1x2x1 blcoks");
            p.Algorithms.Add(NewAlg("F R U' R' U' [R U R' F'] {[R U R' U'] [R' F R F']}", "Two-Handed", "This is just two OLLs combined, they use Sledgehammer too.", false));
            p.Algorithms.Add(NewAlg("R2 U' R2' U' R2 U R' F' R U R2' U' R' F R", "One-Handed - Left Hand", "One-Handed - Left Hand: Double Flick the R2's", false));
            PLL.Add(p);

            p = NewPerm("V", "V.png", "This is V perm it is quite hard to memorize, but is fun to execute.");
            p.Algorithms.Add(NewAlg("[R' U R' d'] [R' F'] [R2 U' R' U] [R' F R F]", "Two-Handed", "Try and make it comfortable.", false));
            p.Algorithms.Add(NewAlg("R U2 R' D R U' R U' R U R2 D R' U' R D2", "One-Handed - Left Hand", "One-Handed - Left Hand: The D moves are wierd don't try and flick the D2's", false));
            PLL.Add(p);

            p = NewPerm("T", "T.png", "T");
            p.Algorithms.Add(NewAlg("[R U R' U'] [R' F] [R2 U' R'] U' [R U R' F']", "Two-Handed", "Just like a Y-Perm just the OLLs are flipped and there is an R2", false));
            p.Algorithms.Add(NewAlg("R2 U R2 U' R2 U' D R2 U' R2 U R2 D'", "One-Handed - Left", "One-Handed - Left Hand: Flick the R2's the U moves go: U U' U' U' U", false));
            PLL.Add(p);

            p = NewPerm("E", "E.png", "You might hate this one.");
            p.Algorithms.Add(NewAlg("x' (R U' R') D (R U R') D' (R U R') D (R U' R') D' ", "Two-Handed & One Handed - Left Hand", "No Tips :(", false));
            //p.Algorithms.Add(NewAlg("aaaa", "aaaa", "aaaa", true));
            PLL.Add(p);

            p = NewPerm("F", "F.png", "This one is just like a V perm just with some U2 in the beggining");
            p.Algorithms.Add(NewAlg("[R' U2 R' d'] [R' F'] [R2 U' R' U] [R' F R U' F]", "Two-Handed", "Finger Flick U2", true));
            p.Algorithms.Add(NewAlg(" y2 R U R' U' R' U R U2 R' L' U R U' L U' R U' R'", "One-Handed - Left Hand", "One-Handed - Left Hand: It's long and it sucks get over it.", true));
            PLL.Add(p);

            p = NewPerm("A(a)", "A(a).png", "There are two A perms and they are both easy.");
            p.Algorithms.Add(NewAlg("x [(R' U R') D2] [(R U' R') D2] R2", "Two-Handed & One Handed - Left Hand", "Finger Flick D2's", false));
            //p.Algorithms.Add(NewAlg("aaaa", "aaaa", "aaaa", false));
            PLL.Add(p);

            p = NewPerm("A(b)", "A(b).png", "looks the same as the last one just the headlights are rotated 90 degrees.");
            p.Algorithms.Add(NewAlg("  y x' [(R U' R) D2] [(R' U R) D2] R2", "Two-Handed & One Handed - Left Hand", "Finger Flick D2's", true));
            //p.Algorithms.Add(NewAlg("aaaa", "aaaa", "aaaa", false);
            PLL.Add(p);

            p = NewPerm("U(a)", "U(a).png", "Super easy and fast (Rotates Edges Counter-Clockwise)");
            p.Algorithms.Add(NewAlg("[R U'] [R U] [R U] [R U'] R' U' R2", "One Handed - Left Hand & Two-Handed", "One-Handed - Left Hand: With one hand finger flick R2, Two Handed: I like to use both index fingers for U moves.", false));
            p.Algorithms.Add(NewAlg("F2 U R' L F2 R L' U F2", "Two-Handed", "Two-Handed: This is the one I first learned may be a but easier to learn", false));
            p.Algorithms.Add(NewAlg("M2 U M U2 M' U M2", "Two-Handed", "Two-Handed: Double Flick M-Slices - CCW", false));
            PLL.Add(p);

            p = NewPerm("U(b)", "U(b).png", "Super easy and fast (Rotates Clockwise)");
            p.Algorithms.Add(NewAlg("R2 U[R U R' U'](R' U')(R' U R')", "One Handed - Left Hand & Two-Handed", "One-Handed - Left Hand: Easy", true));
            p.Algorithms.Add(NewAlg("F2 U' R' L F2 R L' U' F2", "Two-Handed", "Same as U(a) with the F2's just the U moves are inverted.", true));
            p.Algorithms.Add(NewAlg("M2 U' M U2 M' U' M2", "Two-Handed", "Double Flick M-Slices - CW", false));
            PLL.Add(p);

            p = NewPerm("R(a)", "R(a).png", "You do most of the moves with your left hand");
            p.Algorithms.Add(NewAlg("[L U2' L' U2'] [L F'] [L' U' L U] [L F] L2' U", "Two-Handed", "Finger flick the U2.", false));
            p.Algorithms.Add(NewAlg("y R U R' F' R U2 R' U2 R' F R U R U2 R'", "One-Handed - Left Hand", "One-Handed - Left Hand: Finger flick the U2's", false));
            PLL.Add(p);

            p = NewPerm("R(b)", "R(b).png", "You do most of the moves with your right hand");
            p.Algorithms.Add(NewAlg("[R' U2 R U2] [R' F] [R U R' U'] [R' F'] R2 U'", "Two-Handed", "Finger flick the U2.", false));
            p.Algorithms.Add(NewAlg("R' U2 R U2 R' F R U R' U' R' F' R2", "One-Handed - Left Hand", "One-Handed - Left Hand: It works really well even with the F moves", false));
            PLL.Add(p);

            p = NewPerm("J(a)", "J(a).png", "This one goes super fast.");
            p.Algorithms.Add(NewAlg("L' U2 L U L' U2 R U' L U R'", "Two-Handed", "Finger Flick U2's", false));
            p.Algorithms.Add(NewAlg("z U' R2 U R U' R2 z' R U' z U R z' R'", "One-Handed - Left Hand", "One-Handed - Left Hand: Just the Two-Handed Alg, but with z moves to make it more comfortable.", false));
            PLL.Add(p);

            p = NewPerm("J(b)", "J(b).png", "This one goes super fast.");
            p.Algorithms.Add(NewAlg("R U2 R' U' R U2 L' U R' U' L", "Two-Handed", "Finger Flick U2's", false));
            p.Algorithms.Add(NewAlg("R U2 R' U' R U2 z U' R D' R' U", "One-Handed - Left Hand", "One-Handed - Left Hand: Just the Two-Handed Version with a z move to make more comfortable to do.", false));
            PLL.Add(p);

            p = NewPerm("N(a)", "N(a).png", "Pretty Meh to do, but hey this one is symmetrical!");
            p.Algorithms.Add(NewAlg("{(L U' R) U2 (L' U R')} {(L U' R) U2 (L' U R')} U", "Two-Handed", "Finger Flick U2's", true));
            p.Algorithms.Add(NewAlg("(R U R' U) (R U R') F' (R U R') U' R' F R2 U' R' U2 (R U' R')", "One-Handed - Left Hand", "One-Handed - Left Hand: Long but gets the job done.", true));
            PLL.Add(p);

            p = NewPerm("N(b)", "N(b).png", "Pretty Meh to do, but hey this one is symmetrical!");
            p.Algorithms.Add(NewAlg("{(R' U L') U2 (R U' L)} {(R' U L') U2 (R U' L)} U'", "Two-Handed", "Finger Flick U2's", true));
            p.Algorithms.Add(NewAlg("z U' R D' R2 U R' D U' R D' R2 U R' D z'", "One-Handed - Left Hand", "One-Handed - Left Hand: Meh, you could use the one above as one handed too.", true));
            PLL.Add(p);

            p = NewPerm("G(a)", "G(a).png", "G Perms have a pair G(a) & G(b) and then G(c) & G(d)");
            p.Algorithms.Add(NewAlg("R2 u R' U R' U' R u' R2 [y' R' U R]", "Two-Handed and One-Handed - Left Hand", "It Works for both Two hand and One Hand", false));
            //p.Algorithms.Add(NewAlg("aaaa", "aaaa", "aaaa", true));
            PLL.Add(p);

            p = NewPerm("G(b)", "G(b).png", "G Perms have a pair G(a) & G(b) and then G(c) & G(d)");
            p.Algorithms.Add(NewAlg("[R' U' R] y R2 u R' U R U' R u' R2", "Two-Handed and One-Handed - Left Hand", "It Works for both Two hand and One Hand", false));
            //p.Algorithms.Add(NewAlg("aaaa", "aaaa", "aaaa", true));
            PLL.Add(p);

            p = NewPerm("G(c)", "G(c).png", "G Perms have a pair G(a) & G(b) and then G(c) & G(d)");
            p.Algorithms.Add(NewAlg("R2 u' R U' R U R' u R2 [y R U' R']", "Two-Handed and One-Handed - Left Hand", "It Works for both Two hand and One Hand", false));
            //p.Algorithms.Add(NewAlg("aaaa", "aaaa", "aaaa", true));
            PLL.Add(p);

            p = NewPerm("G(d)", "G(d).png", "G Perms have a pair G(a) & G(b) and then G(c) & G(d)");
            p.Algorithms.Add(NewAlg("[R U R'] y' R2 u' R U' R' U R' u R2", "Two-Handed and One-Handed - Left Hand", "It Works for both Two hand and One Hand", false));
            //p.Algorithms.Add(NewAlg("aaaa", "aaaa", "aaaa", true));
            PLL.Add(p);

        }
        private static Algorithm NewAlg(string Alg, string type, string pt, bool symmetry)
        {
            var retVal = new Algorithm();
            retVal.AlgDisplay = Alg;
            retVal.Type = type;
            retVal.ProTip = pt;
            retVal.Symetrical = symmetry;

            return retVal;
        }
        private static Perm NewPerm(string title, string img, string pt)
        {
            var retVal = new Perm();
            retVal.Title = title;
            retVal.ImgPath = "\\Permpics\\" + img;
            retVal.ProTip = pt;

            return retVal;
        }
    }
}
