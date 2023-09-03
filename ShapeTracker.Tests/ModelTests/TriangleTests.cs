using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System.Collections.Generic;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class TriangleTests : IDisposable
  {
    public void Dispose()
    {
      Triangle.ClearAll();
    }


    [TestMethod]
    public void TriangleConstructor_CreatesInstanceOfTriangle_Triangle()
    {
      Triangle newTriangle = new Triangle(3, 3, 3);
      Assert.AreEqual(typeof(Triangle), newTriangle.GetType());
    }

     [TestMethod]
    public void GetSide1_ReturnsSide1_Int()
    {
      int length1 = 3;
      Triangle newTriangle = new Triangle(length1, 3, 3);
      int result = newTriangle.Side1;
      Assert.AreEqual(length1, result);
    }

     [TestMethod]
    public void SetSide1_SetsValueOfSide1_Void()
    {
      // Arrange
      Triangle newTriangle = new Triangle(3, 3, 3);
      int newLength1 = 5;
      // Act
      newTriangle.Side1 = newLength1;
      // Assert
      Assert.AreEqual(newLength1, newTriangle.Side1);
    }

    [TestMethod]
    public void GetSide2_ReturnsSide2_Int()
    {
      // Arrange
      int length2 = 3;
      Triangle newTriangle = new Triangle(3, length2, 3);
      // Act
      int result = newTriangle.Side2;
      // Assert
      Assert.AreEqual(length2, result);
    }

    [TestMethod]
    public void SetSide2_SetsValueOfSide2_Int()
    {
      // Arrange
      Triangle newTriangle = new Triangle(3, 3, 3);
      int newLength2 = 7;
      // Act
      newTriangle.Side2 = newLength2;
      // Assert
      Assert.AreEqual(newLength2, newTriangle.Side2);
    }

    [TestMethod]
    public void GetSide3_ReturnsSide3_Int()
    {
      // Arrange
      int length3 = 3;
      Triangle newTriangle = new Triangle(3, 3, length3);
      // Act
      int result = newTriangle.Side3;
      // Assert
      Assert.AreEqual(length3, result);
    }

    [TestMethod]
    public void SetSide3_SetsValueOfSide3_Int()
    {
      Triangle newTriangle = new Triangle(3, 3, 3);
      int newLength3 = 5;
      newTriangle.Side3 = newLength3;
      Assert.AreEqual(newLength3, newTriangle.Side3);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenNotATriangle_String()
    {
      Triangle newTriangle = new Triangle(3, 3, 110);
      string result = newTriangle.CheckType();
      Assert.AreEqual("not a triangle", result);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenScalene_String()
    {
      Triangle newTriangle = new Triangle(3, 4, 5);
      string result = newTriangle.CheckType();
      Assert.AreEqual("scalene triangle", result);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenIsosceles_String()
    {
      Triangle newTriangle = new Triangle(3, 3, 5);
      string result = newTriangle.CheckType();
      Assert.AreEqual("isosceles triangle", result);
    }

    [TestMethod]
    public void CheckType_DeterminesWhenEquilateral_String()
    {
      Triangle newTriangle = new Triangle(3, 3, 3);
      string result = newTriangle.CheckType();
      Assert.AreEqual("equilateral triangle", result);
    }
    
    [TestMethod]
    public void GetAll_ReturnListOfTriangles_List()
    {
      Triangle newTriangle1 = new Triangle(3, 3, 3);
      Triangle newTriangle2 = new Triangle(3, 3, 3);
      List<Triangle> newList = new List<Triangle> { newTriangle1, newTriangle2 };
      List<Triangle> result = Triangle.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ClearsInstancesOfTriangle_Void()
    {
      Triangle newTriangle1 = new Triangle(3, 3, 3);
      Triangle newTriangle2 = new Triangle(3, 3, 3);
      Triangle.ClearAll();
      List<Triangle> newList = new List<Triangle> { };
      List<Triangle> result = Triangle.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}