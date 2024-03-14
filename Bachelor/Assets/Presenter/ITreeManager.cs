using System;
using System.Collections.Generic;

namespace DefaultNamespace;

public interface ITreeManager
{
    public void WaitForRotateRight();
    public void WaitForRotateLeft();
    public void WaitForFliColour();
    public void SetCurrentHint();
}