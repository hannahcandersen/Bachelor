public enum AvatarHints
{
//Selecting a wrong placement for the ingredient:
SelectWrongPlacementForIngredient,
//Selecting the right placement for the ingredient (and tree is balanced):
SelectRightPlacementAndInBalanced,
//Selecting the right placement for the ingredient - but it causes the tree to become unbalanced(rotate left and flipColour)
    RightPlacementButNeedsToSelectThreeNodes,
//Selecting the right placement for the ingredient - but it causes the tree to become unbalanced(rotate right)
    RightPlacementButNeedsToSelectTwoNodes,
//#Selecting a wrong button (Rotate left, Flip, Rotate right)
    SelectWrongButton,
//#Selecting the right button (Rotate left, Flip, Rotate right)
    SelectRightButton
//#Selecting the right button (Rotate left, Flip, Rotate right) but the tree is still unbalanced
    RightRotationtButNeedsToSelectThreeNodes,
//#Selecting the right button (Rotate left, Flip, Rotate right) but the tree is still unbalanced
    RightRotationtButNeedsToSelectTwoNodes,
//#When a subtree has been put in the bag and need to be replaced in the tree:
    NodeInTheJar,
//#When the potion is finished being brewed
    PotionBrewed
}