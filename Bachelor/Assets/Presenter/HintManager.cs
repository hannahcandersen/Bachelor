namespace DefaultNamespace;

public class HintManager : iHintManager
{
    private Dictionary<TreeBalanceAction, string> hintsdict = new Dictionary<TreeBalanceAction, string>();
    public HintManager()
    {
        hintsdict.add(AvatartHints.SelectWrongPlacementForIngredient, "Hmm, you have selected the wrong placement for that ingredient");
        hintsdict.add(AvatartHints.SelectRightPlacementAndInBalanced, "Perfect placement! You have selected the right placement for the ingredient and the tree is balanced");
        hintsdict.add(AvatartHints.RightPlacementButNeedsToSelectThreeNodes, "You have selected the right placement for the ingredient, but it causes the tree to become unbalanced. You need to select three nodes");
        hintsdict.add(AvatartHints.RightPlacementButNeedsToSelectTwoNodes, "You have selected the right placement for the ingredient, but it causes the tree to become unbalanced. You need to select two nodes");
        hintsdict.add(AvatartHints.SelectWrongButton, "You have selected the wrong button. Please try again");
        hintsdict.add(AvatartHints.SelectRightButton, "Good job! You have selected the right button");
        hintsdict.add(AvatartHints.RightRotationtButNeedsToSelectThreeNodes, "You have selected the right button, but the tree is still unbalanced. You need to select three nodes");
        hintsdict.add(AvatartHints.RightRotationtButNeedsToSelectTwoNodes, "You have selected the right button, but the tree is still unbalanced. You need to select two nodes");
        hintsdict.add(AvatartHints.NodeInTheJar, "A subtree has been put in the bag and need to be replaced in the tree");
        hintsdict.add(AvatartHints.PotionBrewed, "The potion is finished being brewed");
        
    }
}



/*
 *///Selecting a wrong placement for the ingredient:
   //SelectWrongPlacementForIngredient,
   //Selecting the right placement for the ingredient (and tree is balanced):
   //SelectRightPlacementAndInBalanced,
   //Selecting the right placement for the ingredient - but it causes the tree to become unbalanced(rotate left and flipColour)
   //RightPlacementButNeedsToSelectThreeNodes,
   //Selecting the right placement for the ingredient - but it causes the tree to become unbalanced(rotate right)
   //RightPlacementButNeedsToSelectTwoNodes,
   //#Selecting a wrong button (Rotate left, Flip, Rotate right)
   //SelectWrongButton,
   //#Selecting the right button (Rotate left, Flip, Rotate right)
   //SelectRightButton
   //#Selecting the right button (Rotate left, Flip, Rotate right) but the tree is still unbalanced
   //RightRotationtButNeedsToSelectThreeNodes,
   //#Selecting the right button (Rotate left, Flip, Rotate right) but the tree is still unbalanced
   //RightRotationtButNeedsToSelectTwoNodes,
   //#When a subtree has been put in the bag and need to be replaced in the tree:
   //NodeInTheJar,
   //#When the potion is finished being brewed
   //PotionBrewed
 *
 *
 * 
 */