﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.1+g046e9eb0a2
//       
//       Command:
//           LottieGen -Language CSharp -Public -WinUIVersion 2.4 -InputFile SunCircle2.json
//       
//       Input file:
//           SunCircle2.json (16804 bytes created 12:40+05:30 Aug 28 2023)
//       
//       LottieGen source:
//           http://aka.ms/Lottie
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
// ____________________________________
// |       Object stats       | Count |
// |__________________________|_______|
// | All CompositionObjects   |   158 |
// |--------------------------+-------|
// | Expression animators     |    19 |
// | KeyFrame animators       |    19 |
// | Reference parameters     |    19 |
// | Expression operations    |     0 |
// |--------------------------+-------|
// | Animated brushes         |     7 |
// | Animated gradient stops  |     - |
// | ExpressionAnimations     |     8 |
// | PathKeyFrameAnimations   |     - |
// |--------------------------+-------|
// | ContainerVisuals         |     1 |
// | ShapeVisuals             |     1 |
// |--------------------------+-------|
// | ContainerShapes          |    12 |
// | CompositionSpriteShapes  |     8 |
// |--------------------------+-------|
// | Brushes                  |     7 |
// | Gradient stops           |     - |
// | CompositionVisualSurface |     - |
// ------------------------------------
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.UI;
using Windows.UI.Composition;

namespace Drizzle.UI.UWP.AnimatedIcons
{
    // Name:        Comp 1
    // Frame rate:  24 fps
    // Frame count: 156
    // Duration:    6500.0 mS
    sealed class SunCircle2
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
    {
        // Animation duration: 6.500 seconds.
        internal const long c_durationTicks = 65000000;

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (SunCircle2_AnimatedVisual.IsRuntimeCompatible())
            {
                var res = 
                    new SunCircle2_AnimatedVisual(
                        compositor
                        );
                    return res;
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 156d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 24d;

        /// <summary>
        /// Gets the duration of the animation.
        /// </summary>
        public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);

        /// <summary>
        /// Converts a zero-based frame number to the corresponding progress value denoting the
        /// start of the frame.
        /// </summary>
        public double FrameToProgress(double frameNumber)
        {
            return frameNumber / 156d;
        }

        /// <summary>
        /// Returns a map from marker names to corresponding progress values.
        /// </summary>
        public IReadOnlyDictionary<string, double> Markers =>
            new Dictionary<string, double>
            {
            };

        /// <summary>
        /// Sets the color property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetColorProperty(string propertyName, Color value)
        {
        }

        /// <summary>
        /// Sets the scalar property with the given name, or does nothing if no such property
        /// exists.
        /// </summary>
        public void SetScalarProperty(string propertyName, double value)
        {
        }

        sealed class SunCircle2_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 65000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            CompositionColorBrush _animatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_5;
            CompositionEllipseGeometry _ellipse_91p5;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ExpressionAnimation _rootProgress;
            ExpressionAnimation _rootProgressRemapped_0;
            ExpressionAnimation _rootProgressRemapped_1;
            ExpressionAnimation _rootProgressRemapped_2;
            ExpressionAnimation _rootProgressRemapped_3;
            ExpressionAnimation _rootProgressRemapped_4;
            StepEasingFunction _holdThenStepEasingFunction;
            StepEasingFunction _stepThenHoldEasingFunction;

            static void StartProgressBoundAnimation(
                CompositionObject target,
                string animatedPropertyName,
                CompositionAnimation animation,
                ExpressionAnimation controllerProgressExpression)
            {
                target.StartAnimation(animatedPropertyName, animation);
                var controller = target.TryGetAnimationController(animatedPropertyName);
                controller.Pause();
                controller.StartAnimation("Progress", controllerProgressExpression);
            }

            void BindProperty(
                CompositionObject target,
                string animatedPropertyName,
                string expression,
                string referenceParameterName,
                CompositionObject referencedObject)
            {
                _reusableExpressionAnimation.ClearAllParameters();
                _reusableExpressionAnimation.Expression = expression;
                _reusableExpressionAnimation.SetReferenceParameter(referenceParameterName, referencedObject);
                target.StartAnimation(animatedPropertyName, _reusableExpressionAnimation);
            }

            ColorKeyFrameAnimation CreateColorKeyFrameAnimation(float initialProgress, Color initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateColorKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InterpolationColorSpace = CompositionColorSpace.Rgb;
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CompositionSpriteShape CreateSpriteShape(CompositionGeometry geometry, Matrix3x2 transformMatrix, CompositionBrush fillBrush)
            {
                var result = _c.CreateSpriteShape(geometry);
                result.TransformMatrix = transformMatrix;
                result.FillBrush = fillBrush;
                return result;
            }

            // - - - Layer aggregator
            // - ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            // Color
            ColorKeyFrameAnimation ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_0()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0x7F, 0xF6, 0xD4, 0x1D), HoldThenStepEasingFunction());
                // Frame 73.89.
                // TransparentAlmostGold_00F6D41D
                result.InsertKeyFrame(0.473684222F, Color.FromArgb(0x00, 0xF6, 0xD4, 0x1D), CubicBezierEasingFunction_0());
                return result;
            }

            // - - - Layer aggregator
            // - ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            // Color
            ColorKeyFrameAnimation ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_1()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0x7F, 0xF6, 0xD4, 0x1D), _holdThenStepEasingFunction);
                // Frame 87.75.
                // TransparentAlmostGold_00F6D41D
                result.InsertKeyFrame(0.5625F, Color.FromArgb(0x00, 0xF6, 0xD4, 0x1D), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - - Layer aggregator
            // - ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            // Color
            ColorKeyFrameAnimation ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_2()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0x7F, 0xF6, 0xD4, 0x1D), _holdThenStepEasingFunction);
                // Frame 108.
                // TransparentAlmostGold_00F6D41D
                result.InsertKeyFrame(0.692307711F, Color.FromArgb(0x00, 0xF6, 0xD4, 0x1D), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - - Layer aggregator
            // - ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            // Color
            ColorKeyFrameAnimation ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_3()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0x7F, 0xF6, 0xD4, 0x1D), StepThenHoldEasingFunction());
                // Frame 36.
                // SemiTransparentAlmostGold_7FF6D41D
                result.InsertKeyFrame(0.230769232F, Color.FromArgb(0x7F, 0xF6, 0xD4, 0x1D), _holdThenStepEasingFunction);
                // Frame 144.
                // TransparentAlmostGold_00F6D41D
                result.InsertKeyFrame(0.923076928F, Color.FromArgb(0x00, 0xF6, 0xD4, 0x1D), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - - - Layer aggregator
            // - - - Layer: Shape Layer 5
            // - ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            // Color
            ColorKeyFrameAnimation ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_4()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0x7F, 0xF6, 0xD4, 0x1D), _stepThenHoldEasingFunction);
                // Frame 62.4.
                // SemiTransparentAlmostGold_7FF6D41D
                result.InsertKeyFrame(0.400000006F, Color.FromArgb(0x7F, 0xF6, 0xD4, 0x1D), _holdThenStepEasingFunction);
                // Frame 156.
                // TransparentAlmostGold_00F6D41D
                result.InsertKeyFrame(1F, Color.FromArgb(0x00, 0xF6, 0xD4, 0x1D), _cubicBezierEasingFunction_0);
                return result;
            }

            // Color
            ColorKeyFrameAnimation ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_5()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0x7F, 0xF6, 0xD4, 0x1D), _stepThenHoldEasingFunction);
                // Frame 78.
                // SemiTransparentAlmostGold_7FF6D41D
                result.InsertKeyFrame(0.5F, Color.FromArgb(0x7F, 0xF6, 0xD4, 0x1D), _holdThenStepEasingFunction);
                // Frame 156.
                // TransparentAlmostGold_00F6D41D
                result.InsertKeyFrame(1F, Color.FromArgb(0x00, 0xF6, 0xD4, 0x1D), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - - - Layer aggregator
            // - - - Layer: Shape Layer 7
            // - ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            // Color
            ColorKeyFrameAnimation ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_6()
            {
                // Frame 0.
                var result = CreateColorKeyFrameAnimation(0F, Color.FromArgb(0x7F, 0xF6, 0xD4, 0x1D), _stepThenHoldEasingFunction);
                // Frame 89.14.
                // SemiTransparentAlmostGold_7FF6D41D
                result.InsertKeyFrame(0.571428597F, Color.FromArgb(0x7F, 0xF6, 0xD4, 0x1D), _holdThenStepEasingFunction);
                // Frame 156.
                // TransparentAlmostGold_00F6D41D
                result.InsertKeyFrame(1F, Color.FromArgb(0x00, 0xF6, 0xD4, 0x1D), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Layer aggregator
            // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            CompositionColorBrush AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_0()
            {
                var result = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_0(), RootProgressRemapped_0());
                return result;
            }

            // - - Layer aggregator
            // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            CompositionColorBrush AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_1()
            {
                var result = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_1(), RootProgressRemapped_1());
                return result;
            }

            // - - Layer aggregator
            // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            CompositionColorBrush AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_2()
            {
                var result = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_2(), RootProgress());
                return result;
            }

            // - - Layer aggregator
            // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            CompositionColorBrush AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_3()
            {
                var result = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_3(), _rootProgress);
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: Shape Layer 5
            // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            CompositionColorBrush AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_4()
            {
                var result = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_4(), RootProgressRemapped_2());
                return result;
            }

            CompositionColorBrush AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_5()
            {
                var result = _animatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_5 = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_5(), RootProgressRemapped_3());
                return result;
            }

            // - - - Layer aggregator
            // - - Layer: Shape Layer 7
            // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
            CompositionColorBrush AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_6()
            {
                var result = _c.CreateColorBrush();
                StartProgressBoundAnimation(result, "Color", ColorAnimation_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_6(), RootProgressRemapped_4());
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_00()
            {
                var result = _c.CreateContainerShape();
                result.Offset = new Vector2(762.117004F, 737.882996F);
                // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
                result.Shapes.Add(SpriteShape_0());
                result.StartAnimation("Scale", ScaleVector2Animation_0());
                var controller = result.TryGetAnimationController("Scale");
                controller.Pause();
                BindProperty(controller, "Progress", "_.Progress*0.5909091+0.4090909", "_", _root);
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_01()
            {
                var result = _c.CreateContainerShape();
                result.Offset = new Vector2(762.117004F, 737.882996F);
                // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
                result.Shapes.Add(SpriteShape_1());
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_1(), _rootProgressRemapped_0);
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_02()
            {
                var result = _c.CreateContainerShape();
                result.Offset = new Vector2(762.117004F, 737.882996F);
                // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
                result.Shapes.Add(SpriteShape_2());
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_2(), _rootProgressRemapped_1);
                return result;
            }

            // Layer aggregator
            CompositionContainerShape ContainerShape_03()
            {
                var result = _c.CreateContainerShape();
                result.Offset = new Vector2(762.117004F, 737.882996F);
                // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
                result.Shapes.Add(SpriteShape_3());
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_3(), _rootProgress);
                return result;
            }

            // Layer aggregator
            // Layer: Shape Layer 5
            CompositionContainerShape ContainerShape_04()
            {
                var result = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                result.Shapes.Add(ContainerShape_05());
                StartProgressBoundAnimation(result, "Scale", ShapeVisibilityAnimation_0(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 5
            CompositionContainerShape ContainerShape_05()
            {
                var result = _c.CreateContainerShape();
                result.Offset = new Vector2(762.117004F, 737.882996F);
                // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
                result.Shapes.Add(SpriteShape_4());
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_4(), _rootProgressRemapped_2);
                return result;
            }

            // Layer aggregator
            // Layer: Shape Layer 6
            CompositionContainerShape ContainerShape_06()
            {
                var result = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                result.Shapes.Add(ContainerShape_07());
                StartProgressBoundAnimation(result, "Scale", ShapeVisibilityAnimation_1(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 6
            CompositionContainerShape ContainerShape_07()
            {
                var result = _c.CreateContainerShape();
                result.Offset = new Vector2(762.117004F, 737.882996F);
                // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
                result.Shapes.Add(SpriteShape_5());
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_5(), _rootProgressRemapped_3);
                return result;
            }

            // Layer aggregator
            // Layer: Shape Layer 7
            CompositionContainerShape ContainerShape_08()
            {
                var result = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                result.Shapes.Add(ContainerShape_09());
                StartProgressBoundAnimation(result, "Scale", ShapeVisibilityAnimation_2(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 7
            CompositionContainerShape ContainerShape_09()
            {
                var result = _c.CreateContainerShape();
                result.Offset = new Vector2(762.117004F, 737.882996F);
                // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
                result.Shapes.Add(SpriteShape_6());
                StartProgressBoundAnimation(result, "Scale", ScaleVector2Animation_6(), _rootProgressRemapped_4);
                return result;
            }

            // Layer aggregator
            // Layer: Shape Layer 8
            CompositionContainerShape ContainerShape_10()
            {
                var result = _c.CreateContainerShape();
                result.Scale = new Vector2(0F, 0F);
                result.Shapes.Add(ContainerShape_11());
                StartProgressBoundAnimation(result, "Scale", ShapeVisibilityAnimation_3(), _rootProgress);
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            CompositionContainerShape ContainerShape_11()
            {
                var result = _c.CreateContainerShape();
                result.Offset = new Vector2(762.117004F, 737.882996F);
                // ShapeGroup: Ellipse 1 Offset:<-1.5, 1.5>
                result.Shapes.Add(SpriteShape_7());
                result.StartAnimation("Scale", ScaleVector2Animation_7());
                var controller = result.TryGetAnimationController("Scale");
                controller.Pause();
                BindProperty(controller, "Progress", "_.Progress*0.5416667", "_", _root);
                return result;
            }

            // Ellipse Path 1.EllipseGeometry
            CompositionEllipseGeometry Ellipse_91p5()
            {
                var result = _ellipse_91p5 = _c.CreateEllipseGeometry();
                result.Radius = new Vector2(91.5F, 91.5F);
                return result;
            }

            // - Layer aggregator
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                // Offset:<-1.5, 1.5>
                var geometry = Ellipse_91p5();
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, -1.5F, 1.5F), AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_0());;
                return result;
            }

            // - Layer aggregator
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                // Offset:<-1.5, 1.5>
                var geometry = _ellipse_91p5;
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, -1.5F, 1.5F), AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_1());;
                return result;
            }

            // - Layer aggregator
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_2()
            {
                // Offset:<-1.5, 1.5>
                var geometry = _ellipse_91p5;
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, -1.5F, 1.5F), AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_2());;
                return result;
            }

            // - Layer aggregator
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_3()
            {
                // Offset:<-1.5, 1.5>
                var geometry = _ellipse_91p5;
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, -1.5F, 1.5F), AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_3());;
                return result;
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 5
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_4()
            {
                // Offset:<-1.5, 1.5>
                var geometry = _ellipse_91p5;
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, -1.5F, 1.5F), AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_4());;
                return result;
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 6
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_5()
            {
                // Offset:<-1.5, 1.5>
                var geometry = _ellipse_91p5;
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, -1.5F, 1.5F), AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_5());;
                return result;
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 7
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_6()
            {
                // Offset:<-1.5, 1.5>
                var geometry = _ellipse_91p5;
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, -1.5F, 1.5F), AnimatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_6());;
                return result;
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 8
            // Ellipse Path 1
            CompositionSpriteShape SpriteShape_7()
            {
                // Offset:<-1.5, 1.5>
                var geometry = _ellipse_91p5;
                var result = CreateSpriteShape(geometry, new Matrix3x2(1F, 0F, 0F, 1F, -1.5F, 1.5F), _animatedColorBrush_SemiTransparentAlmostGold_7FF6D41D_to_TransparentAlmostGold_00F6D41D_5);;
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                // Layer aggregator
                result.Children.InsertAtTop(ShapeVisual_0());
                return result;
            }

            CubicBezierEasingFunction CubicBezierEasingFunction_0()
            {
                return _cubicBezierEasingFunction_0 = _c.CreateCubicBezierEasingFunction(new Vector2(0.166999996F, 0.166999996F), new Vector2(0.833000004F, 0.833000004F));
            }

            ExpressionAnimation RootProgress()
            {
                var result = _rootProgress = _c.CreateExpressionAnimation("_.Progress");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            ExpressionAnimation RootProgressRemapped_0()
            {
                var result = _rootProgressRemapped_0 = _c.CreateExpressionAnimation("_.Progress*0.6842105+0.3157895");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            ExpressionAnimation RootProgressRemapped_1()
            {
                var result = _rootProgressRemapped_1 = _c.CreateExpressionAnimation("_.Progress*0.8125+0.1875");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            ExpressionAnimation RootProgressRemapped_2()
            {
                var result = _rootProgressRemapped_2 = _c.CreateExpressionAnimation("_.Progress*0.8666667");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            ExpressionAnimation RootProgressRemapped_3()
            {
                var result = _rootProgressRemapped_3 = _c.CreateExpressionAnimation("_.Progress*0.7222222");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            ExpressionAnimation RootProgressRemapped_4()
            {
                var result = _rootProgressRemapped_4 = _c.CreateExpressionAnimation("_.Progress*0.6190476");
                result.SetReferenceParameter("_", _root);
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(1500F, 1500F);
                var shapes = result.Shapes;
                shapes.Add(ContainerShape_00());
                shapes.Add(ContainerShape_01());
                shapes.Add(ContainerShape_02());
                shapes.Add(ContainerShape_03());
                // Layer: Shape Layer 5
                shapes.Add(ContainerShape_04());
                // Layer: Shape Layer 6
                shapes.Add(ContainerShape_06());
                // Layer: Shape Layer 7
                shapes.Add(ContainerShape_08());
                // Layer: Shape Layer 8
                shapes.Add(ContainerShape_10());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            StepEasingFunction StepThenHoldEasingFunction()
            {
                var result = _stepThenHoldEasingFunction = _c.CreateStepEasingFunction();
                result.IsInitialStepSingleFrame = true;
                return result;
            }

            // - Layer aggregator
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 85.09.
                result.InsertKeyFrame(0.545454562F, new Vector2(8.07800007F, 8.07800007F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Layer aggregator
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 98.53.
                result.InsertKeyFrame(0.631578922F, new Vector2(8.07800007F, 8.07800007F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Layer aggregator
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_2()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 117.
                result.InsertKeyFrame(0.75F, new Vector2(8.07800007F, 8.07800007F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Layer aggregator
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_3()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 144.
                result.InsertKeyFrame(0.923076928F, new Vector2(8.07800007F, 8.07800007F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 5
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_4()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _stepThenHoldEasingFunction);
                // Frame 31.2.
                result.InsertKeyFrame(0.200000003F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 156.
                result.InsertKeyFrame(1F, new Vector2(8.07800007F, 8.07800007F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 6
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_5()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _stepThenHoldEasingFunction);
                // Frame 52.
                result.InsertKeyFrame(0.333333343F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 156.
                result.InsertKeyFrame(1F, new Vector2(8.07800007F, 8.07800007F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 7
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_6()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _stepThenHoldEasingFunction);
                // Frame 66.86.
                result.InsertKeyFrame(0.428571433F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 156.
                result.InsertKeyFrame(1F, new Vector2(8.07800007F, 8.07800007F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - - Layer aggregator
            // - Layer: Shape Layer 8
            // Scale
            Vector2KeyFrameAnimation ScaleVector2Animation_7()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _stepThenHoldEasingFunction);
                // Frame 78.
                result.InsertKeyFrame(0.5F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 156.
                result.InsertKeyFrame(1F, new Vector2(8.07800007F, 8.07800007F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 5
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 36.
                result.InsertKeyFrame(0.230769232F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 6
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 72.
                result.InsertKeyFrame(0.461538464F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 7
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_2()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 108.
                result.InsertKeyFrame(0.692307711F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                return result;
            }

            // - Layer aggregator
            // Layer: Shape Layer 8
            Vector2KeyFrameAnimation ShapeVisibilityAnimation_3()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(0F, 0F), _holdThenStepEasingFunction);
                // Frame 144.
                result.InsertKeyFrame(0.923076928F, new Vector2(1F, 1F), _holdThenStepEasingFunction);
                return result;
            }

            internal SunCircle2_AnimatedVisual(
                Compositor compositor
                )
            {
                _c = compositor;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(1500F, 1500F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}
