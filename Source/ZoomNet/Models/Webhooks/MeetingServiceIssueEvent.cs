using Newtonsoft.Json;
using ZoomNet.Utilities;

namespace ZoomNet.Models.Webhooks
{
	/// <summary>
	/// This event is triggered every time a service issue is encountered during a meting.when a meeting is created.
	/// The following quality metrics can trigger an alert:
	/// - Unstable audio.
	/// - Unstable video.
	/// - Poor screen share quality.
	/// - High CPU usage.
	/// - Call reconnection problems.
	/// </summary>
	public class MeetingServiceIssueEvent : Event
	{
		/// <summary>
		/// Gets or sets the meeting object.
		/// </summary>
		[JsonProperty(PropertyName = "object")]
		[JsonConverter(typeof(MeetingConverter))]
		public Meeting Meeting { get; set; }

		/// <summary>
		/// Gets or sets the issues that occured during the meeting.
		/// </summary>
		public string Issues { get; set; }
	}
}
