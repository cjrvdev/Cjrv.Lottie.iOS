using System;
using CoreAnimation;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;

namespace Crjv.Lottie.iOS
{
	// @interface AnimatedControl : UIControl
	[BaseType (typeof(UIControl), Name = "_TtC6Lottie15AnimatedControl")]
	interface AnimatedControl
	{
		// @property (getter = isEnabled, nonatomic) BOOL enabled;
		[Export ("enabled")]
		bool Enabled { [Bind ("isEnabled")] get; set; }

		// @property (getter = isSelected, nonatomic) BOOL selected;
		[Export ("selected")]
		bool Selected { [Bind ("isSelected")] get; set; }

		// @property (getter = isHighlighted, nonatomic) BOOL highlighted;
		[Export ("highlighted")]
		bool Highlighted { [Bind ("isHighlighted")] get; set; }

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// -(BOOL)beginTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
		[Export ("beginTrackingWithTouch:withEvent:")]
		bool BeginTrackingWithTouch (UITouch touch, [NullAllowed] UIEvent @event);

		// -(BOOL)continueTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
		[Export ("continueTrackingWithTouch:withEvent:")]
		bool ContinueTrackingWithTouch (UITouch touch, [NullAllowed] UIEvent @event);

		// -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)event;
		[Export ("endTrackingWithTouch:withEvent:")]
		void EndTrackingWithTouch ([NullAllowed] UITouch touch, [NullAllowed] UIEvent @event);

		// -(void)cancelTrackingWithEvent:(UIEvent * _Nullable)event;
		[Export ("cancelTrackingWithEvent:")]
		void CancelTrackingWithEvent ([NullAllowed] UIEvent @event);
	}

	// @interface AnimatedButton : AnimatedControl
	[BaseType (typeof(AnimatedControl), Name = "_TtC6Lottie14AnimatedButton")]
	interface AnimatedButton
	{
		// -(BOOL)beginTrackingWithTouch:(UITouch * _Nonnull)touch withEvent:(UIEvent * _Nullable)event __attribute__((warn_unused_result("")));
		[Export ("beginTrackingWithTouch:withEvent:")]
		bool BeginTrackingWithTouch (UITouch touch, [NullAllowed] UIEvent @event);

		// -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)event;
		[Export ("endTrackingWithTouch:withEvent:")]
		void EndTrackingWithTouch ([NullAllowed] UITouch touch, [NullAllowed] UIEvent @event);

		// @property (nonatomic) UIAccessibilityTraits accessibilityTraits;
		[Export ("accessibilityTraits")]
		ulong AccessibilityTraits { get; set; }
	}

	// @interface AnimatedSwitch : AnimatedControl
	[BaseType (typeof(AnimatedControl), Name = "_TtC6Lottie14AnimatedSwitch")]
	interface AnimatedSwitch
	{
		// -(void)endTrackingWithTouch:(UITouch * _Nullable)touch withEvent:(UIEvent * _Nullable)event;
		[Export ("endTrackingWithTouch:withEvent:")]
		void EndTrackingWithTouch ([NullAllowed] UITouch touch, [NullAllowed] UIEvent @event);

		// @property (nonatomic) UIAccessibilityTraits accessibilityTraits;
		[Export ("accessibilityTraits")]
		ulong AccessibilityTraits { get; set; }
	}

	// @interface AnimationSubview : UIView
	[BaseType (typeof(UIView), Name = "_TtC6Lottie16AnimationSubview")]
	interface AnimationSubview
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);
	}

	// @interface CompatibleAnimation : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6Lottie19CompatibleAnimation")]
	[DisableDefaultCtor]
	interface CompatibleAnimation
	{
		// -(instancetype _Nonnull)initWithName:(NSString * _Nonnull)name subdirectory:(NSString * _Nullable)subdirectory bundle:(NSBundle * _Nonnull)bundle __attribute__((objc_designated_initializer));
		[Export ("initWithName:subdirectory:bundle:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string name, [NullAllowed] string subdirectory, NSBundle bundle);

		// +(CompatibleAnimation * _Nonnull)named:(NSString * _Nonnull)name __attribute__((warn_unused_result("")));
		[Static]
		[Export ("named:")]
		CompatibleAnimation Named (string name);
	}

	// @interface CompatibleAnimationKeypath : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6Lottie26CompatibleAnimationKeypath")]
	[DisableDefaultCtor]
	interface CompatibleAnimationKeypath
	{
		// -(instancetype _Nonnull)initWithKeypath:(NSString * _Nonnull)keypath __attribute__((objc_designated_initializer));
		[Export ("initWithKeypath:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string keypath);

		// -(instancetype _Nonnull)initWithKeys:(NSArray<NSString *> * _Nonnull)keys __attribute__((objc_designated_initializer));
		[Export ("initWithKeys:")]
		[DesignatedInitializer]
		NativeHandle Constructor (string[] keys);
	}

	// @interface CompatibleAnimationView : UIView
	[BaseType (typeof(UIView), Name = "_TtC6Lottie23CompatibleAnimationView")]
	interface CompatibleAnimationView
	{
		// -(instancetype _Nonnull)initWithCompatibleAnimation:(CompatibleAnimation * _Nonnull)compatibleAnimation;
		[Export ("initWithCompatibleAnimation:")]
		NativeHandle Constructor (CompatibleAnimation compatibleAnimation);

		// -(instancetype _Nonnull)initWithCompatibleAnimation:(CompatibleAnimation * _Nonnull)compatibleAnimation compatibleRenderingEngineOption:(enum CompatibleRenderingEngineOption)compatibleRenderingEngineOption __attribute__((objc_designated_initializer));
		[Export ("initWithCompatibleAnimation:compatibleRenderingEngineOption:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CompatibleAnimation compatibleAnimation, CompatibleRenderingEngineOption compatibleRenderingEngineOption);

		// -(instancetype _Nonnull)initWithUrl:(NSURL * _Nonnull)url;
		[Export ("initWithUrl:")]
		NativeHandle Constructor (NSUrl url);

		// -(instancetype _Nonnull)initWithUrl:(NSURL * _Nonnull)url compatibleRenderingEngineOption:(enum CompatibleRenderingEngineOption)compatibleRenderingEngineOption __attribute__((objc_designated_initializer));
		[Export ("initWithUrl:compatibleRenderingEngineOption:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSUrl url, CompatibleRenderingEngineOption compatibleRenderingEngineOption);

		// -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data;
		[Export ("initWithData:")]
		NativeHandle Constructor (NSData data);

		// -(instancetype _Nonnull)initWithData:(NSData * _Nonnull)data compatibleRenderingEngineOption:(enum CompatibleRenderingEngineOption)compatibleRenderingEngineOption __attribute__((objc_designated_initializer));
		[Export ("initWithData:compatibleRenderingEngineOption:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSData data, CompatibleRenderingEngineOption compatibleRenderingEngineOption);

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// @property (nonatomic, strong) CompatibleAnimation * _Nullable compatibleAnimation;
		[NullAllowed, Export ("compatibleAnimation", ArgumentSemantic.Strong)]
		CompatibleAnimation CompatibleAnimation { get; set; }

		// @property (nonatomic) CGFloat loopAnimationCount;
		[Export ("loopAnimationCount")]
		nfloat LoopAnimationCount { get; set; }

		// @property (nonatomic, strong) CompatibleDictionaryTextProvider * _Nullable compatibleDictionaryTextProvider;
		[NullAllowed, Export ("compatibleDictionaryTextProvider", ArgumentSemantic.Strong)]
		CompatibleDictionaryTextProvider CompatibleDictionaryTextProvider { get; set; }

		// @property (nonatomic) UIViewContentMode contentMode;
		[Export ("contentMode", ArgumentSemantic.Assign)]
		UIViewContentMode ContentMode { get; set; }

		// @property (nonatomic) BOOL shouldRasterizeWhenIdle;
		[Export ("shouldRasterizeWhenIdle")]
		bool ShouldRasterizeWhenIdle { get; set; }

		// @property (nonatomic) CGFloat currentProgress;
		[Export ("currentProgress")]
		nfloat CurrentProgress { get; set; }

		// @property (readonly, nonatomic) CGFloat duration;
		[Export ("duration")]
		nfloat Duration { get; }

		// @property (nonatomic) NSTimeInterval currentTime;
		[Export ("currentTime")]
		double CurrentTime { get; set; }

		// @property (nonatomic) CGFloat currentFrame;
		[Export ("currentFrame")]
		nfloat CurrentFrame { get; set; }

		// @property (readonly, nonatomic) CGFloat realtimeAnimationFrame;
		[Export ("realtimeAnimationFrame")]
		nfloat RealtimeAnimationFrame { get; }

		// @property (readonly, nonatomic) CGFloat realtimeAnimationProgress;
		[Export ("realtimeAnimationProgress")]
		nfloat RealtimeAnimationProgress { get; }

		// @property (nonatomic) CGFloat animationSpeed;
		[Export ("animationSpeed")]
		nfloat AnimationSpeed { get; set; }

		// @property (nonatomic) BOOL respectAnimationFrameRate;
		[Export ("respectAnimationFrameRate")]
		bool RespectAnimationFrameRate { get; set; }

		// @property (readonly, nonatomic) BOOL isAnimationPlaying;
		[Export ("isAnimationPlaying")]
		bool IsAnimationPlaying { get; }

		// @property (nonatomic) enum CompatibleBackgroundBehavior backgroundMode;
		[Export ("backgroundMode", ArgumentSemantic.Assign)]
		CompatibleBackgroundBehavior BackgroundMode { get; set; }

		// -(void)play;
		[Export ("play")]
		void Play ();

		// -(void)playWithCompletion:(void (^ _Nullable)(BOOL))completion;
		[Export ("playWithCompletion:")]
		void PlayWithCompletion ([NullAllowed] Action<bool> completion);

		// -(void)playFromProgress:(CGFloat)fromProgress toProgress:(CGFloat)toProgress completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("playFromProgress:toProgress:completion:")]
		void PlayFromProgress (nfloat fromProgress, nfloat toProgress, [NullAllowed] Action<bool> completion);

		// -(void)playFromFrame:(CGFloat)fromFrame toFrame:(CGFloat)toFrame completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("playFromFrame:toFrame:completion:")]
		void PlayFromFrame (nfloat fromFrame, nfloat toFrame, [NullAllowed] Action<bool> completion);

		// -(void)playFromMarker:(NSString * _Nonnull)fromMarker toMarker:(NSString * _Nonnull)toMarker completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("playFromMarker:toMarker:completion:")]
		void PlayFromMarker (string fromMarker, string toMarker, [NullAllowed] Action<bool> completion);

		// -(void)playWithMarker:(NSString * _Nonnull)marker completion:(void (^ _Nullable)(BOOL))completion;
		[Export ("playWithMarker:completion:")]
		void PlayWithMarker (string marker, [NullAllowed] Action<bool> completion);

		// -(void)stop;
		[Export ("stop")]
		void Stop ();

		// -(void)pause;
		[Export ("pause")]
		void Pause ();

		// -(void)reloadImages;
		[Export ("reloadImages")]
		void ReloadImages ();

		// -(void)forceDisplayUpdate;
		[Export ("forceDisplayUpdate")]
		void ForceDisplayUpdate ();

		// -(id _Nullable)getValueFor:(CompatibleAnimationKeypath * _Nonnull)keypath atFrame:(CGFloat)atFrame __attribute__((warn_unused_result("")));
		[Export ("getValueFor:atFrame:")]
		[return: NullAllowed]
		NSObject GetValueFor (CompatibleAnimationKeypath keypath, nfloat atFrame);

		// -(void)logHierarchyKeypaths;
		[Export ("logHierarchyKeypaths")]
		void LogHierarchyKeypaths ();

		// -(void)setColorValue:(UIColor * _Nonnull)color forKeypath:(CompatibleAnimationKeypath * _Nonnull)keypath;
		[Export ("setColorValue:forKeypath:")]
		void SetColorValue (UIColor color, CompatibleAnimationKeypath keypath);

		// -(UIColor * _Nullable)getColorValueFor:(CompatibleAnimationKeypath * _Nonnull)keypath atFrame:(CGFloat)atFrame __attribute__((warn_unused_result("")));
		[Export ("getColorValueFor:atFrame:")]
		[return: NullAllowed]
		UIColor GetColorValueFor (CompatibleAnimationKeypath keypath, nfloat atFrame);

		// -(void)addSubview:(AnimationSubview * _Nonnull)subview forLayerAt:(CompatibleAnimationKeypath * _Nonnull)keypath;
		[Export ("addSubview:forLayerAt:")]
		void AddSubview (AnimationSubview subview, CompatibleAnimationKeypath keypath);

		// -(CGRect)convertWithRect:(CGRect)rect toLayerAt:(CompatibleAnimationKeypath * _Nullable)keypath __attribute__((warn_unused_result("")));
		[Export ("convertWithRect:toLayerAt:")]
		CGRect ConvertWithRect (CGRect rect, [NullAllowed] CompatibleAnimationKeypath keypath);

		// -(CGPoint)convertWithPoint:(CGPoint)point toLayerAt:(CompatibleAnimationKeypath * _Nullable)keypath __attribute__((warn_unused_result("")));
		[Export ("convertWithPoint:toLayerAt:")]
		CGPoint ConvertWithPoint (CGPoint point, [NullAllowed] CompatibleAnimationKeypath keypath);

		// -(CGFloat)progressTimeForMarker:(NSString * _Nonnull)named __attribute__((warn_unused_result("")));
		[Export ("progressTimeForMarker:")]
		nfloat ProgressTimeForMarker (string named);

		// -(CGFloat)frameTimeForMarker:(NSString * _Nonnull)named __attribute__((warn_unused_result("")));
		[Export ("frameTimeForMarker:")]
		nfloat FrameTimeForMarker (string named);

		// -(CGFloat)durationFrameTimeForMarker:(NSString * _Nonnull)named __attribute__((warn_unused_result("")));
		[Export ("durationFrameTimeForMarker:")]
		nfloat DurationFrameTimeForMarker (string named);
	}

	// @interface CompatibleDictionaryTextProvider : NSObject
	[BaseType (typeof(NSObject), Name = "_TtC6Lottie32CompatibleDictionaryTextProvider")]
	[DisableDefaultCtor]
	interface CompatibleDictionaryTextProvider
	{
		// -(instancetype _Nonnull)initWithValues:(NSDictionary<NSString *,NSString *> * _Nonnull)values __attribute__((objc_designated_initializer));
		[Export ("initWithValues:")]
		[DesignatedInitializer]
		NativeHandle Constructor (NSDictionary<NSString, NSString> values);
	}

	// @interface LottieAnimationViewBase : UIView
	[BaseType (typeof(UIView), Name = "_TtC6Lottie23LottieAnimationViewBase")]
	interface LottieAnimationViewBase
	{
		// @property (nonatomic) UIViewContentMode contentMode;
		[Export ("contentMode", ArgumentSemantic.Assign)]
		UIViewContentMode ContentMode { get; set; }

		// -(void)didMoveToWindow;
		[Export ("didMoveToWindow")]
		void DidMoveToWindow ();

		// -(void)layoutSubviews;
		[Export ("layoutSubviews")]
		void LayoutSubviews ();

		// -(void)animationWillMoveToBackground;
		[Export ("animationWillMoveToBackground")]
		void AnimationWillMoveToBackground ();

		// -(void)animationWillEnterForeground;
		[Export ("animationWillEnterForeground")]
		void AnimationWillEnterForeground ();

		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);
	}

	// @interface LottieAnimationView : LottieAnimationViewBase
	[BaseType (typeof(LottieAnimationViewBase), Name = "_TtC6Lottie19LottieAnimationView")]
	interface LottieAnimationView
	{
		// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
		[Export ("initWithFrame:")]
		[DesignatedInitializer]
		NativeHandle Constructor (CGRect frame);

		// @property (readonly, nonatomic) CGSize intrinsicContentSize;
		[Export ("intrinsicContentSize")]
		CGSize IntrinsicContentSize { get; }

		// @property (copy, nonatomic) NSString * _Nullable animationName;
		[NullAllowed, Export ("animationName")]
		string AnimationName { get; set; }

		// -(void)animationWillMoveToBackground;
		[Export ("animationWillMoveToBackground")]
		void AnimationWillMoveToBackground ();

		// -(void)animationWillEnterForeground;
		[Export ("animationWillEnterForeground")]
		void AnimationWillEnterForeground ();
	}
}
