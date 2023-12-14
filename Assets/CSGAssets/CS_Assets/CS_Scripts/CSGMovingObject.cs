using System.Collections;
using UnityEngine;
using ColorSwitchGame.Types;

namespace ColorSwitchGame
{
	/// <summary>
	/// This script defines a moving object, which can move between waypoints and rotate
	/// </summary>
	public class CSGMovingObject : MonoBehaviour
	{
		// Various variables we will access often during the game, so we cache them
		internal Transform thisTransform;
		internal Vector2 initialPosition;
		internal float initialRotation;

		[Tooltip("A list of waypoints the object moves through")]
		public Waypoint[] waypoints;
		internal int currentWaypoint = 0;
		internal bool isWaiting = false;

		[Tooltip("The speed at which the object moves")]
		public float moveSpeed = 10;

		[Tooltip("The speed at which the object rotates")]
		public float rotateSpeed;

		[Tooltip("Ping Pong makes the object rotate in a pendulum motion, back and forth")]
		public bool rotatePingPong = false;

		[Tooltip("The chance for this object to rotate and move in reverse")]
		public float reverseChance = 0;
		internal bool isReverse = false;

		/// <summary>
		/// Start is only called once in the lifetime of the behaviour.
		/// The difference between Awake and Start is that Start is only called if the script instance is enabled.
		/// This allows you to delay any initialization code, until it is really needed.
		/// Awake is always called before any Start functions.
		/// This allows you to order initialization of scripts
		/// </summary>
		void Start()
		{
			thisTransform = transform;

			// Register the initial position and rotation of the object, so that all motion is relative to this
			initialPosition = thisTransform.localPosition;
			initialRotation = thisTransform.localEulerAngles.z;

			// There is a chance for the motion to be in reverse
			if ( Random.value < reverseChance )    
			{
				// We are in reverse
				isReverse = true;

				// Reverse the rotation speed
				rotateSpeed *= -1;
			}
		}

		/// <summary>
		/// Update is called every frame, if the MonoBehaviour is enabled.
		/// </summary>
		void Update()
		{
			// If we have a rotation speed set, rotate
			if ( rotateSpeed != 0 )    
			{
				// If pingpong, rotate in a smooth pendulum motion. Otherwise rotate in the direction and speed set
				if ( rotatePingPong == true )    thisTransform.eulerAngles = Vector3.forward * (initialRotation + Mathf.Sin(Time.time * rotateSpeed * 0.01f) * 180);
				else    thisTransform.eulerAngles += Vector3.forward * rotateSpeed * Time.deltaTime;
			}

			// If we have waypoints set, move through them
			if ( waypoints.Length > 0 )
			{
				// If we haven't reached the next waypoint yet, keep moving towards it
				if ( (Vector2)thisTransform.localPosition != (Vector2)initialPosition + waypoints[currentWaypoint].waypoint )
				{
					// Move towards the next waypoint position, relative to the initial position of the object
					thisTransform.localPosition = Vector2.MoveTowards( thisTransform.localPosition, (Vector2)initialPosition + waypoints[currentWaypoint].waypoint, Time.deltaTime * moveSpeed);
				}
				else if ( isWaiting == false )
				{
					isWaiting = true;

					// If we are moving in reverse, move to the previous waypoint. Otherwise move to the next waypoint.
					if ( isReverse == true )    StartCoroutine(ChangeWaypoint( 1, waypoints[currentWaypoint].waitTime));
					else    StartCoroutine(ChangeWaypoint( -1, waypoints[currentWaypoint].waitTime));
				}
			}
		}

		/// <summary>
		/// Changes the current waypoint, after a delay
		/// </summary>
		/// <returns>The waypoint.</returns>
		/// <param name="changeValue">The new waypoint index</param>
		/// <param name="delay">The delay in seconds before moving to the next waypoint</param>
		IEnumerator ChangeWaypoint( int changeValue, float delay ) 
		{
			// Wait for some time
			yield return new WaitForSeconds(delay);

			// Change the current waypoint index
			currentWaypoint += changeValue;

			// Loop through the waypoints list, and set the new positions accordingly
			if ( currentWaypoint > waypoints.Length - 1 )    
			{
				// The first waypoint
				currentWaypoint = 0;

				// If we moved from the last waypoint to the first, teleport the object to the new position
				thisTransform.localPosition = (Vector2)initialPosition + waypoints[currentWaypoint].waypoint;
			}
			else if ( currentWaypoint < 0 )    
			{
				// The last waypoint
				currentWaypoint = waypoints.Length - 1;

				// If we moved from the first waypoint to the last, teleport the object to the new position
				thisTransform.localPosition = (Vector2)initialPosition + waypoints[currentWaypoint].waypoint;
			}

			// We are no longer waiting at this waypoint
			isWaiting = false;
		}

		void OnDrawGizmos()
		{
			Gizmos.color = Color.red;

			foreach ( Waypoint waypoint in waypoints )
			{
				// Draw the position of the next waypoint
				Gizmos.DrawWireSphere( (Vector2)transform.position + waypoint.waypoint, 0.2f);
			}
		}
	}
}