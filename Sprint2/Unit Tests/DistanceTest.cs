using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NUnit.Framework;

public class DistanceTest
{
    [Test]
    public void calculateDistance()
    {
        //ARRANGE
        var distanceCalculator = new Distance();
        var player_position = new Vector3(0.0f, 1.0f, 2.1f);
        var startingPosition = new Vector3(0.0f,1.0f,0.6f);
        var Distance_ = Vector3.Distance(player_position, startingPosition);
        var expectedDistance = (int)(2.1 - 0.6);

        //ACT
        var distance = Distance.calculateDistance(Distance_);

        //ASSERT
        Assert.That(distance, Is.EqualTo(expectedDistance));

        
    }
}
