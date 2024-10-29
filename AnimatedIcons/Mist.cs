﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.1+g046e9eb0a2
//       
//       Command:
//           LottieGen -Language CSharp -Public -WinUIVersion 2.4 -InputFile mist.json
//       
//       Input file:
//           mist.json (3614 bytes created 22:35+05:30 Dec 23 2023)
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
// | All CompositionObjects   |    42 |
// |--------------------------+-------|
// | Expression animators     |     3 |
// | KeyFrame animators       |     3 |
// | Reference parameters     |     3 |
// | Expression operations    |     0 |
// |--------------------------+-------|
// | Animated brushes         |     - |
// | Animated gradient stops  |     - |
// | ExpressionAnimations     |     1 |
// | PathKeyFrameAnimations   |     - |
// |--------------------------+-------|
// | ContainerVisuals         |     1 |
// | ShapeVisuals             |     1 |
// |--------------------------+-------|
// | ContainerShapes          |     - |
// | CompositionSpriteShapes  |     3 |
// |--------------------------+-------|
// | Brushes                  |     3 |
// | Gradient stops           |     3 |
// | CompositionVisualSurface |     - |
// ------------------------------------
using Microsoft.Graphics.Canvas.Geometry;
using System;
using System.Collections.Generic;
using System.Numerics;
using Windows.Graphics;
using Windows.UI;
using Windows.UI.Composition;

namespace Drizzle.UI.UWP.AnimatedIcons
{
    // Name:        mist
    // Frame rate:  60 fps
    // Frame count: 360
    // Duration:    6000.0 mS
    sealed class Mist
        : Microsoft.UI.Xaml.Controls.IAnimatedVisualSource
    {
        // Animation duration: 6.000 seconds.
        internal const long c_durationTicks = 60000000;

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor)
        {
            object ignored = null;
            return TryCreateAnimatedVisual(compositor, out ignored);
        }

        public Microsoft.UI.Xaml.Controls.IAnimatedVisual TryCreateAnimatedVisual(Compositor compositor, out object diagnostics)
        {
            diagnostics = null;

            if (Mist_AnimatedVisual.IsRuntimeCompatible())
            {
                var res = 
                    new Mist_AnimatedVisual(
                        compositor
                        );
                    return res;
            }

            return null;
        }

        /// <summary>
        /// Gets the number of frames in the animation.
        /// </summary>
        public double FrameCount => 360d;

        /// <summary>
        /// Gets the frame rate of the animation.
        /// </summary>
        public double Framerate => 60d;

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
            return frameNumber / 360d;
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

        sealed class Mist_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 60000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            CompositionColorGradientStop _gradientStop_0_AlmostLightGray_FFD3D6DD;
            CompositionColorGradientStop _gradientStop_0p45_AlmostLightGray_FFD3D6DD;
            CompositionColorGradientStop _gradientStop_1_AlmostSilver_FFBDC1C5;
            CompositionPathGeometry _pathGeometry;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ExpressionAnimation _rootProgress;
            StepEasingFunction _holdThenStepEasingFunction;

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

            Vector2KeyFrameAnimation CreateVector2KeyFrameAnimation(float initialProgress, Vector2 initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateVector2KeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
                result.InsertKeyFrame(initialProgress, initialValue, initialEasingFunction);
                return result;
            }

            CanvasGeometry Geometry()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.BeginFigure(new Vector2(-120F, 0F));
                    builder.AddLine(new Vector2(120F, 0F));
                    builder.EndFigure(CanvasFigureLoop.Open);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // Stop 0
            CompositionColorGradientStop GradientStop_0_AlmostLightGray_FFD3D6DD()
            {
                return _gradientStop_0_AlmostLightGray_FFD3D6DD = _c.CreateColorGradientStop(0F, Color.FromArgb(0xFF, 0xD3, 0xD6, 0xDD));
            }

            // Stop 1
            CompositionColorGradientStop GradientStop_0p45_AlmostLightGray_FFD3D6DD()
            {
                return _gradientStop_0p45_AlmostLightGray_FFD3D6DD = _c.CreateColorGradientStop(0.449999988F, Color.FromArgb(0xFF, 0xD3, 0xD6, 0xDD));
            }

            // Stop 2
            CompositionColorGradientStop GradientStop_1_AlmostSilver_FFBDC1C5()
            {
                return _gradientStop_1_AlmostSilver_FFBDC1C5 = _c.CreateColorGradientStop(1F, Color.FromArgb(0xFF, 0xBD, 0xC1, 0xC5));
            }

            // - Layer aggregator
            // Path 1
            CompositionLinearGradientBrush LinearGradientBrush_0()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(GradientStop_0_AlmostLightGray_FFD3D6DD());
                colorStops.Add(GradientStop_0p45_AlmostLightGray_FFD3D6DD());
                colorStops.Add(GradientStop_1_AlmostSilver_FFBDC1C5());
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(-35.5169983F, -61.8709984F);
                result.EndPoint = new Vector2(36.4830017F, 62.8359985F);
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionLinearGradientBrush LinearGradientBrush_1()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(_gradientStop_0_AlmostLightGray_FFD3D6DD);
                colorStops.Add(_gradientStop_0p45_AlmostLightGray_FFD3D6DD);
                colorStops.Add(_gradientStop_1_AlmostSilver_FFBDC1C5);
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(-35.5169983F, -61.8709984F);
                result.EndPoint = new Vector2(36.4830017F, 62.8359985F);
                return result;
            }

            // - Layer aggregator
            // Path 1
            CompositionLinearGradientBrush LinearGradientBrush_2()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(_gradientStop_0_AlmostLightGray_FFD3D6DD);
                colorStops.Add(_gradientStop_0p45_AlmostLightGray_FFD3D6DD);
                colorStops.Add(_gradientStop_1_AlmostSilver_FFBDC1C5);
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(-35.5169983F, -61.8709984F);
                result.EndPoint = new Vector2(36.4830017F, 62.8359985F);
                return result;
            }

            CompositionPathGeometry PathGeometry()
            {
                return _pathGeometry = _c.CreatePathGeometry(new CompositionPath(Geometry()));
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_0()
            {
                var result = _c.CreateSpriteShape(PathGeometry());
                result.StrokeBrush = LinearGradientBrush_0();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 24F;
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_0(), RootProgress());
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_1()
            {
                var result = _c.CreateSpriteShape(_pathGeometry);
                result.StrokeBrush = LinearGradientBrush_1();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 24F;
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_1(), _rootProgress);
                return result;
            }

            // Layer aggregator
            // Path 1
            CompositionSpriteShape SpriteShape_2()
            {
                var result = _c.CreateSpriteShape(_pathGeometry);
                result.StrokeBrush = LinearGradientBrush_2();
                result.StrokeDashCap = CompositionStrokeCap.Round;
                result.StrokeStartCap = CompositionStrokeCap.Round;
                result.StrokeEndCap = CompositionStrokeCap.Round;
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 24F;
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_2(), _rootProgress);
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

            // Layer aggregator
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(512F, 512F);
                var shapes = result.Shapes;
                // Path 1
                shapes.Add(SpriteShape_0());
                // Path 1
                shapes.Add(SpriteShape_1());
                // Path 1
                shapes.Add(SpriteShape_2());
                return result;
            }

            StepEasingFunction HoldThenStepEasingFunction()
            {
                var result = _holdThenStepEasingFunction = _c.CreateStepEasingFunction();
                result.IsFinalStepSingleFrame = true;
                return result;
            }

            // - Layer aggregator
            // Path 1
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(208F, 200F), HoldThenStepEasingFunction());
                // Frame 180.
                result.InsertKeyFrame(0.5F, new Vector2(304F, 200F), CubicBezierEasingFunction_0());
                // Frame 359.
                result.InsertKeyFrame(0.997222245F, new Vector2(208F, 200F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Layer aggregator
            // Path 1
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(256F, 256F), _holdThenStepEasingFunction);
                // Frame 90.
                result.InsertKeyFrame(0.25F, new Vector2(208F, 256F), _cubicBezierEasingFunction_0);
                // Frame 270.
                result.InsertKeyFrame(0.75F, new Vector2(304F, 256F), _cubicBezierEasingFunction_0);
                // Frame 359.
                result.InsertKeyFrame(0.997222245F, new Vector2(256F, 256F), _cubicBezierEasingFunction_0);
                return result;
            }

            // - Layer aggregator
            // Path 1
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_2()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(304F, 312F), _holdThenStepEasingFunction);
                // Frame 180.
                result.InsertKeyFrame(0.5F, new Vector2(208F, 312F), _cubicBezierEasingFunction_0);
                // Frame 359.
                result.InsertKeyFrame(0.997222245F, new Vector2(304F, 312F), _cubicBezierEasingFunction_0);
                return result;
            }

            internal Mist_AnimatedVisual(
                Compositor compositor
                )
            {
                _c = compositor;
                _reusableExpressionAnimation = compositor.CreateExpressionAnimation();
                Root();
            }

            public Visual RootVisual => _root;
            public TimeSpan Duration => TimeSpan.FromTicks(c_durationTicks);
            public Vector2 Size => new Vector2(512F, 512F);
            void IDisposable.Dispose() => _root?.Dispose();

            internal static bool IsRuntimeCompatible()
            {
                return Windows.Foundation.Metadata.ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7);
            }
        }
    }
}
