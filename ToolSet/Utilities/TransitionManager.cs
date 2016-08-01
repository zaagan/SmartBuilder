using AnimatorNS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Transitions;

namespace SmartBuilder.ToolSet.Utilities
{
    class TransitionManager
    {

        private Animation GetPredefinedAnimation(string name)
        {
            switch (name)
            {
                case "Rotate": return Animation.Rotate;
                case "HorizSlide": return Animation.HorizSlide;
                case "VertSlide": return Animation.VertSlide;
                case "Scale": return Animation.Scale;
                case "ScaleAndRotate": return Animation.ScaleAndRotate;
                case "HorizSlideAndRotate": return Animation.HorizSlideAndRotate;
                case "ScaleAndHorizSlide": return Animation.ScaleAndHorizSlide;
                case "Transparent": return Animation.Transparent;
                case "Leaf": return Animation.Leaf;
                case "Mosaic": return Animation.Mosaic;
                case "Particles": return Animation.Particles;
                case "VertBlind": return Animation.VertBlind;
                case "HorizBlind": return Animation.HorizBlind;
            }
            return Animation.Scale;
        }

        public static Animation GetPredefinedAnimation(int type)
        {
            switch (type)
            {
                case 1: return Animation.Rotate;
                case 2: return Animation.HorizSlide;
                case 3: return Animation.VertSlide;
                case 4: return Animation.Scale;
                case 5: return Animation.ScaleAndRotate;
                case 6: return Animation.HorizSlideAndRotate;
                case 7: return Animation.ScaleAndHorizSlide;
                case 8: return Animation.Transparent;
                case 9: return Animation.Leaf;
                case 10: return Animation.Mosaic;
                case 11: return Animation.Particles;
                case 12: return Animation.VertBlind;
                case 13: return Animation.HorizBlind;
            }
            return Animation.Scale;
        }

        public static void RelocateControls_RtoLtoR(Control mainScreenControl, Control backControl)
        {
            const int GROUP_BOX_LEFT = 0;

            Control ctrlOnScreen, ctrlOffScreen;
            if (mainScreenControl.Left == GROUP_BOX_LEFT)
            {
                ctrlOnScreen = mainScreenControl;
                ctrlOffScreen = backControl;
            }
            else
            {
                ctrlOnScreen = backControl;
                ctrlOffScreen = mainScreenControl;
            }
            ctrlOnScreen.SendToBack();
            ctrlOffScreen.BringToFront();

            ctrlOnScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            ctrlOnScreen.Size = mainScreenControl.Size;
            ctrlOffScreen.Size = mainScreenControl.Size;
            ctrlOffScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));
            t.add(ctrlOnScreen, "Left", -1 * ctrlOnScreen.Width);
            t.add(ctrlOffScreen, "Left", GROUP_BOX_LEFT);
            t.run();
        }

        public static void RelocateControls_LtoRtoL(int firstLocation, Control mainScreenControl, Control backControl)
        {

            int location = firstLocation;
            //backControl.Width;
            Control ctrlOnScreen, ctrlOffScreen;
            if (mainScreenControl.Left
 == location)
            {
                ctrlOnScreen = mainScreenControl;
                ctrlOffScreen = backControl;
            }
            else
            {
                ctrlOnScreen = backControl;
                ctrlOffScreen = mainScreenControl;
            }
            ctrlOnScreen.SendToBack();
            ctrlOffScreen.BringToFront();

            ctrlOnScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            ctrlOnScreen.Size = mainScreenControl.Size;
            ctrlOffScreen.Size = mainScreenControl.Size;
            ctrlOffScreen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom | AnchorStyles.Right;
            Transition t = new Transition(new TransitionType_EaseInEaseOut(500));

            t.add(ctrlOnScreen, "Left", 0);
            t.add(ctrlOffScreen, "Left", location);
            t.run();
        }


        public static void FlashButton(Control controlToFlash)
        {
            // The button is 'thrown' up to the top of the group-box it is in
            // and then falls back down again. 

            // The throw-and-catch transition starts the animation at a high rate and
            // decelerates to zero (as if against gravity) at the destination value. It 
            // then accelerates the value (as if with gravity) back to the original value.

            Transition.run(controlToFlash, "Top", 12, new TransitionType_ThrowAndCatch(1500));
        }

        public static void ResizeFormLtoRtoL(ref bool isReadyForTransition, Control control, int incrementBy, string strPropertyName = "Width", int transitionTime = 500)
        {
            int iFormWidth;
            int controlProperty = 0;
            if (strPropertyName == "Width")
            { controlProperty = control.Width; }
            else
            { controlProperty = control.Height; }

            if (isReadyForTransition)
            {
                iFormWidth = controlProperty + incrementBy;
                isReadyForTransition = false;
            }
            else
            {
                iFormWidth = controlProperty - incrementBy;
                isReadyForTransition = true;
            }
            Transition.run(control, strPropertyName, iFormWidth, new TransitionType_EaseInEaseOut(transitionTime));
        }


        private static Color BACKCOLOR_PINK = Color.FromArgb(255, 220, 220);
        private static Color BACK_COLOR_YELLOW = Color.FromArgb(255, 255, 220);
        public static void ChangeFormColor(object target, Color backColor)
        {
            Color destination = (backColor == BACKCOLOR_PINK) ? BACK_COLOR_YELLOW : BACKCOLOR_PINK;
            Transition.run(target, "BackColor", destination, new TransitionType_Linear(1000));
        }


        public static void BounceControl(Control containerControl, Control containedControl)
        {
            int iDestination = containerControl.Height - containedControl.Height;
            Transition.run(containedControl, "Top", iDestination, new TransitionType_Bounce(1500));

        }

        public static void BounceChain(Control containerControl, Control containedControl)
        {
            // We animate the button to drop and bounce twice with bounces
            // of diminishing heights. While it does this, it is moving to 
            // the right, as if thrown to the right. When this animation has
            // finished, the button moves back to its original position.

            // The diminishing-bounce is not one of the built-in transition types,
            // so we create it here as a user-defined transition type. You define 
            // these as a collection of TransitionElements. These define how far the
            // animated properties will have moved at various times, and how the 
            // transition between different elements is to be done.

            // So in the example below:
            //  0% - 40%    The button acclerates to 100% distance (i.e. the bottom of the screen)
            // 40% - 65%    The button bounces back (decelerating) to 70% distance.
            // etc...

            IList<TransitionElement> elements = new List<TransitionElement>();
            elements.Add(new TransitionElement(40, 100, InterpolationMethod.Accleration));
            elements.Add(new TransitionElement(65, 70, InterpolationMethod.Deceleration));
            elements.Add(new TransitionElement(80, 100, InterpolationMethod.Accleration));
            elements.Add(new TransitionElement(90, 92, InterpolationMethod.Deceleration));
            elements.Add(new TransitionElement(100, 100, InterpolationMethod.Accleration));

            int iDestination = containerControl.Height - containedControl.Height - 10;
            Transition.run(containedControl, "Top", iDestination, new TransitionType_UserDefined(elements, 2000));

            // The transition above just animates the vertical bounce of the button, but not
            // the left-to-right movement. This can't use the same transition, as otherwise the
            // left-to-right movement would bounce back and forth.

            // We run the left-to-right animation as a second, simultaneous transition. 
            // In fact, we run a transition chain, with the animation of the button back
            // to its starting position as the second item in the chain. The second 
            // transition starts as soon as the first is complete...

            Transition t1 = new Transition(new TransitionType_Linear(2000));
            t1.add(containedControl, "Left", containedControl.Left + 400);

            Transition t2 = new Transition(new TransitionType_EaseInEaseOut(2000));
            t2.add(containedControl, "Top", 19);
            t2.add(containedControl, "Left", 6);

            Transition.runChain(t1, t2);
        }

        public static void BounceThrowAndCatch(Control containedControl)
        { Transition.run(containedControl, "Top", 12, new TransitionType_ThrowAndCatch(1500)); }


        //  private const string STRING_SHORT = "Hello, World!";
        //    private const string STRING_LONG = "A longer piece of text.";
        public static void TextTransition(string oldText, string longText, Control lblTextContainer, Control lblSecondaryTextContainer)
        {
            string strText1, strText2;
            Color color1, color2;
            if (lblTextContainer.Text == oldText)
            {
                strText1 = longText;
                color1 = Color.Red;
                strText2 = oldText;
                color2 = Color.Blue;
            }
            else
            {
                strText1 = oldText;
                color1 = Color.Blue;
                strText2 = longText;
                color2 = Color.Red;
            }

            // We create a transition to animate all four properties at the same time...
            Transition t = new Transition(new TransitionType_Linear(300));
            t.add(lblTextContainer, "Text", strText1);
            t.add(lblTextContainer, "ForeColor", color1);
            t.add(lblSecondaryTextContainer, "Text", strText2);
            t.add(lblSecondaryTextContainer, "ForeColor", color2);
            t.run();
        }




        public static void PictureTransition(Control parentControl, Control m_ActivePicture, Control m_InactivePicture)
        {
            Random m_Random = new Random();
            // We randomly choose where the current image is going to 
            // slide off to (and where we are going to slide the inactive
            // image in from)...
            int iDestinationLeft = (m_Random.Next(2) == 0) ? parentControl.Width : -parentControl.Width;
            int iDestinationTop = (m_Random.Next(3) - 1) * parentControl.Height;

            // We move the inactive image to this location...
            parentControl.SuspendLayout();
            m_InactivePicture.Top = iDestinationTop;
            m_InactivePicture.Left = iDestinationLeft;
            m_InactivePicture.BringToFront();
            parentControl.ResumeLayout();

            // We perform the transition which moves the active image off the
            // screen, and the inactive one onto the screen...
            Transition t = new Transition(new TransitionType_EaseInEaseOut(1000));
            t.add(m_InactivePicture, "Left", 0);
            t.add(m_InactivePicture, "Top", 0);
            t.add(m_ActivePicture, "Left", iDestinationLeft);
            t.add(m_ActivePicture, "Top", iDestinationTop);
            t.run();

            // We swap over which image is active and inactive for next time
            // the function is called...
            Control tmp = m_ActivePicture;
            m_ActivePicture = m_InactivePicture;
            m_InactivePicture = tmp;
        }
    }

}
