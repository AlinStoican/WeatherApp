﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//       LottieGen version:
//           7.1.1+g046e9eb0a2
//       
//       Command:
//           LottieGen -Language CSharp -Public -WinUIVersion 2.4 -InputFile overcast.json
//       
//       Input file:
//           overcast.json (3668 bytes created 12:55+05:30 Aug 3 2023)
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
// | All CompositionObjects   |    52 |
// |--------------------------+-------|
// | Expression animators     |     5 |
// | KeyFrame animators       |     3 |
// | Reference parameters     |     6 |
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
// | CompositionSpriteShapes  |     2 |
// |--------------------------+-------|
// | Brushes                  |     4 |
// | Gradient stops           |     6 |
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
    // Name:        overcast
    // Frame rate:  60 fps
    // Frame count: 360
    // Duration:    6000.0 mS
    sealed class Overcast
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

            if (Overcast_AnimatedVisual.IsRuntimeCompatible())
            {
                var res = 
                    new Overcast_AnimatedVisual(
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

        sealed class Overcast_AnimatedVisual : Microsoft.UI.Xaml.Controls.IAnimatedVisual
        {
            const long c_durationTicks = 60000000;
            readonly Compositor _c;
            readonly ExpressionAnimation _reusableExpressionAnimation;
            ContainerVisual _root;
            CubicBezierEasingFunction _cubicBezierEasingFunction_0;
            ExpressionAnimation _rootProgress;
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

            ScalarKeyFrameAnimation CreateScalarKeyFrameAnimation(float initialProgress, float initialValue, CompositionEasingFunction initialEasingFunction)
            {
                var result = _c.CreateScalarKeyFrameAnimation();
                result.Duration = TimeSpan.FromTicks(c_durationTicks);
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

            // - - - Layer aggregator
            // - - dark-path
            CanvasGeometry Geometry_0()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(22.8120003F, 8.56200027F));
                    builder.AddCubicBezier(new Vector2(22.8120003F, 26.4769993F), new Vector2(37.3349991F, 41F), new Vector2(55.25F, 41F));
                    builder.AddLine(new Vector2(185F, 41F));
                    builder.AddLine(new Vector2(185F, 40.8829994F));
                    builder.AddCubicBezier(new Vector2(185.768997F, 40.9339981F), new Vector2(186.535004F, 41F), new Vector2(187.317001F, 41F));
                    builder.AddCubicBezier(new Vector2(206.511002F, 41F), new Vector2(222.070999F, 25.4389992F), new Vector2(222.070999F, 6.24499989F));
                    builder.AddCubicBezier(new Vector2(222.070999F, -10.7299995F), new Vector2(209.895004F, -24.8409996F), new Vector2(193.804001F, -27.882F));
                    builder.AddCubicBezier(new Vector2(194.085007F, -29.5979996F), new Vector2(194.268005F, -31.3470001F), new Vector2(194.268005F, -33.1430016F));
                    builder.AddCubicBezier(new Vector2(194.268005F, -51.0579987F), new Vector2(179.744995F, -65.5810013F), new Vector2(161.830002F, -65.5810013F));
                    builder.AddCubicBezier(new Vector2(155.770004F, -65.5810013F), new Vector2(150.119003F, -63.8889999F), new Vector2(145.266006F, -60.9959984F));
                    builder.AddCubicBezier(new Vector2(136.690994F, -74.8539963F), new Vector2(121.399002F, -84.1159973F), new Vector2(103.905998F, -84.1159973F));
                    builder.AddCubicBezier(new Vector2(77.0339966F, -84.1159973F), new Vector2(55.25F, -62.3320007F), new Vector2(55.25F, -35.4599991F));
                    builder.AddCubicBezier(new Vector2(55.25F, -31.434F), new Vector2(55.7929993F, -27.5429993F), new Vector2(56.7150002F, -23.8010006F));
                    builder.AddCubicBezier(new Vector2(56.2260017F, -23.823F), new Vector2(55.7449989F, -23.875F), new Vector2(55.25F, -23.875F));
                    builder.AddCubicBezier(new Vector2(37.3349991F, -23.875F), new Vector2(22.8120003F, -9.35299969F), new Vector2(22.8120003F, 8.56200027F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - - - Layer aggregator
            // - - cloud-path
            CanvasGeometry Geometry_1()
            {
                CanvasGeometry result;
                using (var builder = new CanvasPathBuilder(null))
                {
                    builder.SetFilledRegionDetermination(CanvasFilledRegionDetermination.Winding);
                    builder.BeginFigure(new Vector2(116F, -4F));
                    builder.AddCubicBezier(new Vector2(115.146004F, -4F), new Vector2(114.315002F, -3.91100001F), new Vector2(113.471001F, -3.87299991F));
                    builder.AddCubicBezier(new Vector2(115.063004F, -10.3319998F), new Vector2(116F, -17.0489998F), new Vector2(116F, -24F));
                    builder.AddCubicBezier(new Vector2(116F, -70.3919983F), new Vector2(78.3919983F, -108F), new Vector2(32F, -108F));
                    builder.AddCubicBezier(new Vector2(1.79900002F, -108F), new Vector2(-24.6009998F, -92.0090027F), new Vector2(-39.4039993F, -68.0849991F));
                    builder.AddCubicBezier(new Vector2(-47.7820015F, -73.0790024F), new Vector2(-57.5390015F, -76F), new Vector2(-68F, -76F));
                    builder.AddCubicBezier(new Vector2(-98.9280014F, -76F), new Vector2(-124F, -50.9280014F), new Vector2(-124F, -20F));
                    builder.AddCubicBezier(new Vector2(-124F, -16.8999996F), new Vector2(-123.682999F, -13.8800001F), new Vector2(-123.198997F, -10.9169998F));
                    builder.AddCubicBezier(new Vector2(-150.977997F, -5.66699982F), new Vector2(-172F, 18.6940002F), new Vector2(-172F, 48F));
                    builder.AddCubicBezier(new Vector2(-172F, 81.137001F), new Vector2(-145.136993F, 108F), new Vector2(-112F, 108F));
                    builder.AddCubicBezier(new Vector2(-110.649002F, 108F), new Vector2(-109.328003F, 107.886002F), new Vector2(-108F, 107.797997F));
                    builder.AddLine(new Vector2(-108F, 108F));
                    builder.AddLine(new Vector2(116F, 108F));
                    builder.AddCubicBezier(new Vector2(146.927994F, 108F), new Vector2(172F, 82.9280014F), new Vector2(172F, 52F));
                    builder.AddCubicBezier(new Vector2(172F, 21.0720005F), new Vector2(146.927994F, -4F), new Vector2(116F, -4F));
                    builder.EndFigure(CanvasFigureLoop.Closed);
                    result = CanvasGeometry.CreatePath(builder);
                }
                return result;
            }

            // - Layer aggregator
            // cloud-path
            CompositionColorBrush ColorBrush_AlmostLavender_FFE6EFFC()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0xE6, 0xEF, 0xFC));
            }

            // - Layer aggregator
            // dark-path
            CompositionColorBrush ColorBrush_AlmostLightSlateGray_FF848B98()
            {
                return _c.CreateColorBrush(Color.FromArgb(0xFF, 0x84, 0x8B, 0x98));
            }

            // - - Layer aggregator
            // - cloud-path
            // Stop 0
            CompositionColorGradientStop GradientStop_0_AlmostAliceBlue_FFF3F7FD()
            {
                return _c.CreateColorGradientStop(0F, Color.FromArgb(0xFF, 0xF3, 0xF7, 0xFD));
            }

            // - - Layer aggregator
            // - dark-path
            // Stop 0
            CompositionColorGradientStop GradientStop_0_AlmostDarkGray_FF9CA2AE()
            {
                return _c.CreateColorGradientStop(0F, Color.FromArgb(0xFF, 0x9C, 0xA2, 0xAE));
            }

            // - - Layer aggregator
            // - cloud-path
            // Stop 1
            CompositionColorGradientStop GradientStop_0p45_AlmostAliceBlue_FFF3F7FD()
            {
                return _c.CreateColorGradientStop(0.449999988F, Color.FromArgb(0xFF, 0xF3, 0xF7, 0xFD));
            }

            // - - Layer aggregator
            // - dark-path
            // Stop 1
            CompositionColorGradientStop GradientStop_0p45_AlmostDarkGray_FF9CA2AE()
            {
                return _c.CreateColorGradientStop(0.449999988F, Color.FromArgb(0xFF, 0x9C, 0xA2, 0xAE));
            }

            // - - Layer aggregator
            // - cloud-path
            // Stop 2
            CompositionColorGradientStop GradientStop_1_AlmostLavender_FFDEEAFA()
            {
                return _c.CreateColorGradientStop(1F, Color.FromArgb(0xFF, 0xDE, 0xEA, 0xFA));
            }

            // - - Layer aggregator
            // - dark-path
            // Stop 2
            CompositionColorGradientStop GradientStop_1_AlmostSlateGray_FF6B7180()
            {
                return _c.CreateColorGradientStop(1F, Color.FromArgb(0xFF, 0x6B, 0x71, 0x80));
            }

            // - Layer aggregator
            // dark-path
            CompositionLinearGradientBrush LinearGradientBrush_0()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(GradientStop_0_AlmostDarkGray_FF9CA2AE());
                colorStops.Add(GradientStop_0p45_AlmostDarkGray_FF9CA2AE());
                colorStops.Add(GradientStop_1_AlmostSlateGray_FF6B7180());
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(75F, -75F);
                result.EndPoint = new Vector2(155.623993F, 64.6449966F);
                return result;
            }

            // - Layer aggregator
            // cloud-path
            CompositionLinearGradientBrush LinearGradientBrush_1()
            {
                var result = _c.CreateLinearGradientBrush();
                var colorStops = result.ColorStops;
                colorStops.Add(GradientStop_0_AlmostAliceBlue_FFF3F7FD());
                colorStops.Add(GradientStop_0p45_AlmostAliceBlue_FFF3F7FD());
                colorStops.Add(GradientStop_1_AlmostLavender_FFDEEAFA());
                result.MappingMode = CompositionMappingMode.Absolute;
                result.StartPoint = new Vector2(-76F, -81F);
                result.EndPoint = new Vector2(57.1860008F, 149.684998F);
                return result;
            }

            // - Layer aggregator
            // dark-path
            CompositionPathGeometry PathGeometry_0()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_0()));
            }

            // - Layer aggregator
            // cloud-path
            CompositionPathGeometry PathGeometry_1()
            {
                return _c.CreatePathGeometry(new CompositionPath(Geometry_1()));
            }

            // Layer aggregator
            // dark-path
            CompositionSpriteShape SpriteShape_0()
            {
                var result = _c.CreateSpriteShape(PathGeometry_0());
                result.FillBrush = LinearGradientBrush_0();
                result.StrokeBrush = ColorBrush_AlmostLightSlateGray_FF848B98();
                result.StrokeMiterLimit = 5F;
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_0(), RootProgress());
                return result;
            }

            // Layer aggregator
            // cloud-path
            CompositionSpriteShape SpriteShape_1()
            {
                var result = _c.CreateSpriteShape(PathGeometry_1());
                result.FillBrush = LinearGradientBrush_1();
                result.StrokeBrush = ColorBrush_AlmostLavender_FFE6EFFC();
                result.StrokeMiterLimit = 5F;
                result.StrokeThickness = 6F;
                StartProgressBoundAnimation(result, "Offset", OffsetVector2Animation_1(), _rootProgress);
                return result;
            }

            // The root of the composition.
            ContainerVisual Root()
            {
                var result = _root = _c.CreateContainerVisual();
                var propertySet = result.Properties;
                propertySet.InsertScalar("Progress", 0F);
                propertySet.InsertScalar("t0", 0F);
                // Layer aggregator
                result.Children.InsertAtTop(ShapeVisual_0());
                StartProgressBoundAnimation(result.Properties, "t0", t0ScalarAnimation_0_to_1(), _rootProgress);
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

            ScalarKeyFrameAnimation t0ScalarAnimation_0_to_1()
            {
                // Frame 180.
                var result = CreateScalarKeyFrameAnimation(0.50000006F, 0F, _stepThenHoldEasingFunction);
                result.SetReferenceParameter("_", _root);
                // Frame 359.
                result.InsertKeyFrame(0.997222185F, 1F, _cubicBezierEasingFunction_0);
                return result;
            }

            // Layer aggregator
            ShapeVisual ShapeVisual_0()
            {
                var result = _c.CreateShapeVisual();
                result.Size = new Vector2(512F, 512F);
                var shapes = result.Shapes;
                // dark-path
                shapes.Add(SpriteShape_0());
                // cloud-path
                shapes.Add(SpriteShape_1());
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
            // dark-path
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_0()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(247F, 256F), HoldThenStepEasingFunction());
                result.SetReferenceParameter("_", _root);
                // Frame 180.
                result.InsertKeyFrame(0.5F, new Vector2(265F, 256F), CubicBezierEasingFunction_0());
                // Frame 359.
                result.InsertExpressionKeyFrame(0.997222185F, "Pow(1-_.t0,3)*Vector2(265,256)+(3*Square(1-_.t0)*_.t0*Vector2(265,256))+(3*(1-_.t0)*Square(_.t0)*Vector2(250,256))+(Pow(_.t0,3)*Vector2(247,256))", StepThenHoldEasingFunction());
                // Frame 359.
                result.InsertKeyFrame(0.997222245F, new Vector2(247F, 256F), _stepThenHoldEasingFunction);
                return result;
            }

            // - Layer aggregator
            // cloud-path
            // Offset
            Vector2KeyFrameAnimation OffsetVector2Animation_1()
            {
                // Frame 0.
                var result = CreateVector2KeyFrameAnimation(0F, new Vector2(238F, 256F), _holdThenStepEasingFunction);
                result.SetReferenceParameter("_", _root);
                // Frame 180.
                result.InsertKeyFrame(0.5F, new Vector2(274F, 256F), _cubicBezierEasingFunction_0);
                // Frame 359.
                result.InsertExpressionKeyFrame(0.997222185F, "Pow(1-_.t0,3)*Vector2(274,256)+(3*Square(1-_.t0)*_.t0*Vector2(274,256))+(3*(1-_.t0)*Square(_.t0)*Vector2(244,256))+(Pow(_.t0,3)*Vector2(238,256))", _stepThenHoldEasingFunction);
                // Frame 359.
                result.InsertKeyFrame(0.997222245F, new Vector2(238F, 256F), _stepThenHoldEasingFunction);
                return result;
            }

            internal Overcast_AnimatedVisual(
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
