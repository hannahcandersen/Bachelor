namespace DefaultNamespace;

public class HintManager : IHintManager
{
    public Dictionary<AvatarHint, string> HintsDict { get; set; } = new Dictionary<AvatarHint, string>();
    public HintManager()
    {
        HintsDict.add(AvatartHints.SelectedWrongPlacementForIngredient, "Hmm, you have selected the wrong placement for that ingredient");
        Hintsdict.add(AvatartHints.SelectedRightPlacementAndInBalance, "Perfect placement! You have selected the right placement for the ingredient and the tree is balanced");
        Hintsdict.add(AvatartHints.SelectedRightButtonButNeedsToSelectThreeNodes, "You have selected the right placement for the ingredient, but it causes the tree to become unbalanced. You need to select three nodes");
        Hintsdict.add(AvatartHints.SelectedRightButtonButNeedsToSelectTwoNodes, "You have selected the right placement for the ingredient, but it causes the tree to become unbalanced. You need to select two nodes");
        Hintsdict.add(AvatartHints.SelectedWrongButton, "You have selected the wrong button. Please try again");
        Hintsdict.add(AvatartHints.SelectedRightButton, "Good job! You have selected the right button");
        Hintsdict.add(AvatartHints.RightRotationtButNeedsToSelectThreeNodes, "You have selected the right button, but the tree is still unbalanced. You need to select three nodes");
        Hintsdict.add(AvatartHints.RightRotationtButNeedsToSelectTwoNodes, "You have selected the right button, but the tree is still unbalanced. You need to select two nodes");
        Hintsdict.add(AvatartHints.NodeInTheJar, "A subtree has been put in the bag and need to be replaced in the tree");
        Hintsdict.add(AvatartHints.PotionBrewed, "The potion is finished being brewed");
        
    }

    public string GetHint(AvatarHint avatarEnum)
    {
        return HintsDict[avatarEnum];
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